using Microsoft.Data.SqlClient; // To use SqlConnectionStringBuilder.
using Microsoft.EntityFrameworkCore; // To use DbContext.

namespace Northwind.EntityModels;

public partial class NorthwindContext : DbContext
{
  private static readonly SetLastRefreshedInterceptor
    setLastRefreshedInterceptor = new();

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      SqlConnectionStringBuilder builder = new();

      builder.DataSource = "tcp:127.0.0.1,1433"; // SQL Server in container.
      builder.InitialCatalog = "Northwind";
      builder.TrustServerCertificate = true;
      builder.MultipleActiveResultSets = true;

      // Because we want to fail fast. Default is 15 seconds.
      builder.ConnectTimeout = 3;
      
      // SQL Server authentication.
      builder.UserID = Environment.GetEnvironmentVariable("MY_SQL_USR");
      builder.Password = Environment.GetEnvironmentVariable("MY_SQL_PWD");
      
      optionsBuilder.UseSqlServer(builder.ConnectionString);

      optionsBuilder.LogTo(NorthwindContextLogger.WriteLine,
        [ Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting ]);
    }

    optionsBuilder.AddInterceptors(setLastRefreshedInterceptor);
  }
}
