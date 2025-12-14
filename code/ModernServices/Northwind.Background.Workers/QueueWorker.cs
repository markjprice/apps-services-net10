using Northwind.Queue.Models; // To use ProductQueueMessage.
using RabbitMQ.Client; // To use ConnectionFactory.
using RabbitMQ.Client.Events; // To use AsyncEventingBasicConsumer.
using System.Text.Json; // To use JsonSerializer.

namespace Northwind.Background.Workers;

public class QueueWorker : BackgroundService
{
  private readonly ILogger<QueueWorker> _logger;

  // RabbitMQ objects.
  private ConnectionFactory? _factory;
  private IConnection? _connection;
  private IChannel? _channel;
  private AsyncEventingBasicConsumer? _consumer;

  private const string queueNameAndRoutingKey = "product";

  public QueueWorker(ILogger<QueueWorker> logger)
  {
    _logger = logger;
  }

  public override async Task StartAsync(CancellationToken cancellationToken)
  {
    _factory = new() { HostName = "localhost" };
    _connection = await _factory.CreateConnectionAsync();
    _channel = await _connection.CreateChannelAsync();
    _consumer = new(_channel);

    await _channel.QueueDeclareAsync(
      queue: queueNameAndRoutingKey, 
      durable: false,
      exclusive: false, 
      autoDelete: false, 
      arguments: null);

    _consumer = new(_channel);

    _consumer.ReceivedAsync += async (model, args) =>
    {
      byte[] body = args.Body.ToArray();

      ProductQueueMessage? message = JsonSerializer
        .Deserialize<ProductQueueMessage>(body);

      if (message is not null)
      {
        _logger.LogInformation($"Received product. Id: {message.Product.ProductId}, Name: {message.Product
          .ProductName}, Message: {message.Text}");
      }
      else
      {
        _logger.LogInformation($"Received unknown: {args.Body.ToArray()}.");
      }
    };

    // Start consuming as messages arrive in the queue.
    await _channel.BasicConsumeAsync(
      queue: queueNameAndRoutingKey,
      autoAck: true, 
      consumer: _consumer);
  }

  protected override async Task ExecuteAsync(
    CancellationToken stoppingToken)
  {
    while (!stoppingToken.IsCancellationRequested)
    {
      _logger.LogInformation("Worker running at: {time}",
        DateTimeOffset.Now);

      await Task.Delay(1000, stoppingToken);
    }
  }
}
