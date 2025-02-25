using Npgsql; // To use NpgsqlConnection and so on.
using NpgsqlTypes; // To use NpgsqlType and so on.
using Northwind.ViewModels; // To use Product.
using System.Data; // To use CommandType.
using System.Text.Json; // To use Utf8JsonWriter, JsonSerializer.

using static System.Environment;
using static System.IO.Path;
using Dapper;

//ConfigureConsole(); // US English by default.

// Simulate the French culture to test Euro symbol.
ConfigureConsole(culture: "fr-FR");

//ConfigureConsole(useComputerCulture: true);

#region Set up the connection string builder

NpgsqlConnectionStringBuilder builder = new();
builder.Host = "tcp:127.0.0.1,5432";
builder.Database = "Northwind";
builder.Timeout = 10; // Default is 30 seconds.
builder.Port = 5432; ;
builder.Username = "";

Write("Enter your PostgreSQL password: ");
string? password = ReadLine();
if (string.IsNullOrWhiteSpace(password))
{
  WriteLine("Password cannot be empty or null.");
  return;
}

builder.Password = password;
builder.PersistSecurityInfo = false;

#endregion

#region Create and open the connection

NpgsqlConnection connection = new(builder.ConnectionString);

WriteLine(connection.ConnectionString);
WriteLine();

try
{
  WriteLine("Opening connection. Please wait up to {0} seconds...",
    builder.Timeout);
  WriteLine();
  await connection.OpenAsync();

  WriteLine($"PostgreSQL version: {connection.ServerVersion}");
}
catch (NpgsqlException ex)
{
  WriteLineInColor($"SQL exception: {ex.Message}",
    ConsoleColor.Red);
  return;
}

#endregion

Write("Enter a unit price: ");
string? priceText = ReadLine();

if (!decimal.TryParse(priceText, out decimal price))
{
  WriteLine("You must enter a valid unit price.");
  return;
}

NpgsqlCommand cmd = connection.CreateCommand();

WriteLine("Execute command using:");
WriteLine("  1 - Text");
WriteLine("  2 - Stored Procedure");
WriteLine();
Write("Press a key: ");

ConsoleKey key = ReadKey().Key;
WriteLine(); WriteLine();

NpgsqlParameter p1, p2 = new(), p3 = new();

if (key is ConsoleKey.D1 or ConsoleKey.NumPad1)
{
  cmd.CommandType = CommandType.Text;

  cmd.CommandText = "SELECT ProductId, ProductName, UnitPrice FROM Products"
    + " WHERE UnitPrice >= @minimumPrice";

  cmd.Parameters.AddWithValue("minimumPrice", price);
}
else if (key is ConsoleKey.D2 or ConsoleKey.NumPad2)
{
  cmd.CommandType = CommandType.StoredProcedure;
  cmd.CommandText = "GetExpensiveProducts";

  p1 = new()
  {
    ParameterName = "price",
    NpgsqlDbType = NpgsqlDbType.Money,
    NpgsqlValue = price
  };

  p2 = new()
  {
    Direction = ParameterDirection.Output,
    ParameterName = "count",
    NpgsqlDbType = NpgsqlDbType.Integer
  };

  p3 = new()
  {
    Direction = ParameterDirection.ReturnValue,
    ParameterName = "rv",
    NpgsqlDbType = NpgsqlDbType.Integer
  };

  cmd.Parameters.AddRange(new[] { p1, p2, p3 });
}

// The name "reader" would be better practice in the real world
// but "r" is shorter in a print book.
NpgsqlDataReader r = await cmd.ExecuteReaderAsync();

string horizontalLine = new string('-', 60);
WriteLine(horizontalLine);
WriteLine("| {0,5} | {1,-35} | {2,10} |",
  arg0: "Id", arg1: "Name", arg2: "Price");
WriteLine(horizontalLine);

// Define a file path to write to.
string jsonPath = Combine(CurrentDirectory, "products.json");

List<Product> products = new(capacity: 77);

await using (FileStream jsonStream = File.Create(jsonPath))
{
  Utf8JsonWriter jsonWriter = new(jsonStream);
  jsonWriter.WriteStartArray();

  while (await r.ReadAsync())
  {
    Product product = new()
    {
      ProductId = await r.GetFieldValueAsync<int>("ProductId"),
      ProductName = await r.GetFieldValueAsync<string>("ProductName"),
      UnitPrice = await r.GetFieldValueAsync<decimal>("UnitPrice")
    };
    products.Add(product);

    WriteLine("| {0,5} | {1,-35} | {2,10:C} |",
      await r.GetFieldValueAsync<int>("ProductId"),
      await r.GetFieldValueAsync<string>("ProductName"),
      await r.GetFieldValueAsync<decimal>("UnitPrice"));

    jsonWriter.WriteStartObject();

    jsonWriter.WriteNumber("productId",
      await r.GetFieldValueAsync<int>("ProductId"));
    jsonWriter.WriteString("productName",
      await r.GetFieldValueAsync<string>("ProductName"));
    jsonWriter.WriteNumber("unitPrice",
      await r.GetFieldValueAsync<decimal>("UnitPrice"));

    jsonWriter.WriteEndObject();
  }

  jsonWriter.WriteEndArray();
  jsonWriter.Flush();
  jsonStream.Close();
}
WriteLine(horizontalLine);

WriteLineInColor($"Written to: {jsonPath}", ConsoleColor.DarkGreen);

WriteLineInColor(JsonSerializer.Serialize(products),
  ConsoleColor.Magenta);

await r.CloseAsync();

if (key is ConsoleKey.D2 or ConsoleKey.NumPad2)
{
  WriteLine($"Output count: {p2.Value}");
  WriteLine($"Return value: {p3.Value}");
}

await connection.CloseAsync();

#region Using Dapper

WriteLineInColor("Using Dapper", ConsoleColor.DarkGreen);

IEnumerable<Supplier> suppliers = connection.Query<Supplier>(
  sql: "SELECT * FROM Suppliers WHERE Country=@Country",
  param: new { Country = "Germany" });

foreach (Supplier s in suppliers)
{
  WriteLine("{0}: {1}, {2}, {3}",
    s.SupplierId, s.CompanyName, s.City, s.Country);
}

WriteLineInColor(JsonSerializer.Serialize(suppliers),
  ConsoleColor.Green);

IEnumerable<Product> productsFromDapper =
  connection.Query<Product>(sql: "GetExpensiveProducts",
  param: new { price = 100M, count = 0 },
  commandType: CommandType.StoredProcedure);

foreach (Product p in productsFromDapper)
{
  WriteLine("{0}: {1}, {2}",
    p.ProductId, p.ProductName, p.UnitPrice);
}

WriteLineInColor(JsonSerializer.Serialize(productsFromDapper),
  ConsoleColor.Green);

#endregion
