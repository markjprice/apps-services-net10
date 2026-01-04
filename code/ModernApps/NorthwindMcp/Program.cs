using Microsoft.Extensions.DependencyInjection; // To use AddMcpServer.
using Microsoft.Extensions.Hosting; // To use Host.
using Microsoft.Extensions.Logging; // To use AddConsole.

var builder = Host.CreateApplicationBuilder(args);

builder.Logging.AddConsole(consoleLogOptions =>
{
  // Configure all logs to go to stderr.
  consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services
  .AddMcpServer()
  .WithStdioServerTransport()
  .WithToolsFromAssembly();

await builder.Build().RunAsync();
