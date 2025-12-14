using Northwind.Queue.Models; // To use ProductQueueMessage.
using RabbitMQ.Client; // To use ConnectionFactory.
using RabbitMQ.Client.Events; // To use AsyncEventingBasicConsumer.
using System.Text.Json; // To use JsonSerializer.

string queueName = "product";

ConnectionFactory factory = new () { HostName = "localhost" };

using IConnection connection = await factory.CreateConnectionAsync();

using IChannel channel = await connection.CreateChannelAsync();

WriteLine("Declaring queue...");

QueueDeclareOk response = await channel.QueueDeclareAsync(
  queue: queueName,
  durable: false,
  exclusive: false,
  autoDelete: false,
  arguments: null);

WriteLine("Queue name: {0}, Message count: {1}, Consumer count: {2}.",
  response.QueueName, response.MessageCount, response.ConsumerCount);

WriteLine("Waiting for messages...");

AsyncEventingBasicConsumer consumer = new(channel);

consumer.ReceivedAsync += async (model, args) =>
{
  byte[] body = args.Body.ToArray();

  ProductQueueMessage? message = JsonSerializer
    .Deserialize<ProductQueueMessage>(body);

  if (message is not null)
  {
    WriteLine("Received product. Id: {0}, Name: {1}, Message: {2}",
      message.Product.ProductId, message.Product.ProductName, 
      message.Text);
  }
  else
  {
    WriteLine("Received unknown: {0}.", args.Body.ToArray());
  }
};

// Start consuming as messages arrive in the queue.
await channel.BasicConsumeAsync(queue: queueName,
  autoAck: true,
  consumer: consumer);

WriteLine(">>> Press Enter to stop consuming and quit. <<<");
ReadLine();
