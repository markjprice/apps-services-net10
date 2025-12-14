using Microsoft.Data.SqlClient; // To use SqlConnectionStringBuilder.
using Hangfire; // To use GlobalConfiguration.
using Northwind.Background.Models; // To use WriteMessageJobDetail.
using Microsoft.AspNetCore.Mvc; // To use [FromBody].

SqlConnectionStringBuilder connection = new();

connection.InitialCatalog = "Northwind.HangfireDb";
connection.MultipleActiveResultSets = true;
connection.Encrypt = true;
connection.TrustServerCertificate = true;
connection.ConnectTimeout = 5; // Default is 30 seconds.
connection.DataSource = "tcp:127.0.0.1,1433"; // To use SQL Server in a container.

// To use SQL Server authentication.
connection.UserID = Environment.GetEnvironmentVariable("MY_SQL_USR");
connection.Password = Environment.GetEnvironmentVariable("MY_SQL_PWD");
connection.PersistSecurityInfo = false;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(config => config
  .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
  .UseSimpleAssemblyNameTypeSerializer()
  .UseRecommendedSerializerSettings()
  .UseSqlServerStorage(connection.ConnectionString));

builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseHangfireDashboard();

app.MapGet("/", () =>
  "Navigate to /hangfire to see the Hangfire Dashboard.");

app.MapPost("/schedulejob", ([FromBody] WriteMessageJobDetail job) =>
  {
    BackgroundJob.Schedule(
      methodCall: () => WriteMessage(job.Message),
      enqueueAt: DateTimeOffset.UtcNow + 
        TimeSpan.FromSeconds(job.Seconds));
  });

app.MapHangfireDashboard();

app.Run();
