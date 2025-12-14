using Microsoft.AspNetCore.Http.HttpResults; // To use Results<T, T>.
using Microsoft.AspNetCore.Mvc; // To use [FromServices] and so on.
using Northwind.EntityModels; // To use NorthwindContext, Product.
using AspNetCoreRateLimit; // To use IClientPolicyStore and so on.
using System.Security.Claims; // To use ClaimsPrincipal.

namespace Northwind.WebApi.Service.Extensions;

public static class WebApplicationExtensions
{
  public static WebApplication MapGets(
    this WebApplication app, int pageSize = 10)
  {
    app.MapGet("/", () => "Hello World!")
      .ExcludeFromDescription();

    app.MapGet("/secret", (ClaimsPrincipal user) =>
      string.Format("Welcome, {0}. The secret ingredient is love.",
      user.Identity?.Name ?? "secure user"))
      .RequireAuthorization();

    app.MapGet("api/products", (
      [FromServices] NorthwindContext db,
      [FromQuery] int? page) =>
      db.Products
        .Where(p => p.UnitsInStock > 0 && !p.Discontinued)
        .OrderBy(product => product.ProductId)
        .Skip(((page ?? 1) - 1) * pageSize)
        .Take(pageSize)
      )
      .WithName("GetProducts")
      .WithDescription("Gets products with UnitsInStock > 0 and Discontinued = false.")
      .WithSummary("Gets in-stock products that are not discontinued.")
      .Produces<Product[]>(StatusCodes.Status200OK);

    app.MapGet("api/products/outofstock",
      ([FromServices] NorthwindContext db) => db.Products
        .Where(p => p.UnitsInStock == 0 && !p.Discontinued)
      )
      .WithName("GetProductsOutOfStock")
      .WithDescription("Gets products with UnitsInStock = 0 and Discontinued = false.")
      .WithSummary("Gets out-of-stock products that are not discontinued.")
      .Produces<Product[]>(StatusCodes.Status200OK);

    app.MapGet("api/products/discontinued",
      ([FromServices] NorthwindContext db) =>
        db.Products.Where(product => product.Discontinued)
      )
      .WithName("GetProductsDiscontinued")
      .WithDescription("Gets products that are discontinued.")
      .WithSummary("Gets all discontinued products.")
      .Produces<Product[]>(StatusCodes.Status200OK);

    app.MapGet("api/products/{id:int}",
      async Task<Results<Ok<Product>, NotFound>> (
        [FromServices] NorthwindContext db,
        [FromRoute] int id) =>
        await db.Products.FindAsync(id) is Product product ?
          TypedResults.Ok(product) : TypedResults.NotFound())
      .WithName("GetProductById")
      .WithDescription("Gets a product by its ID.")
      .WithSummary("Gets a product by its ID.")
      .Produces<Product>(StatusCodes.Status200OK)
      .Produces(StatusCodes.Status404NotFound);

    app.MapGet("api/products/{name}", (
      [FromServices] NorthwindContext db,
      [FromRoute] string name) =>
        db.Products.Where(p => p.ProductName.Contains(name)))
      .WithName("GetProductsByName")
      .WithDescription("Gets products by their name.")
      .WithSummary("Gets products by their name.")
      .Produces<Product[]>(StatusCodes.Status200OK)
      .RequireCors(policyName: "Northwind.Mvc.Policy");

    return app;
  }

  public static WebApplication MapPosts(this WebApplication app)
  {
    app.MapPost("api/products", async ([FromBody] Product product,
      [FromServices] NorthwindContext db) =>
    {
      db.Products.Add(product);
      await db.SaveChangesAsync();
      return Results.Created($"api/products/{product.ProductId}", product);
    }).Produces<Product>(StatusCodes.Status201Created);

    return app;
  }

  public static WebApplication MapPuts(this WebApplication app)
  {
    app.MapPut("api/products/{id:int}", async (
      [FromRoute] int id,
      [FromBody] Product product,
      [FromServices] NorthwindContext db) =>
    {
      Product? foundProduct = await db.Products.FindAsync(id);
      if (foundProduct is null) return Results.NotFound();
      foundProduct.ProductName = product.ProductName;
      foundProduct.CategoryId = product.CategoryId;
      foundProduct.SupplierId = product.SupplierId;
      foundProduct.QuantityPerUnit = product.QuantityPerUnit;
      foundProduct.UnitsInStock = product.UnitsInStock;
      foundProduct.UnitsOnOrder = product.UnitsOnOrder;
      foundProduct.ReorderLevel = product.ReorderLevel;
      foundProduct.UnitPrice = product.UnitPrice;
      foundProduct.Discontinued = product.Discontinued;
      await db.SaveChangesAsync();
      return Results.NoContent();
    }).Produces(StatusCodes.Status404NotFound)
      .Produces(StatusCodes.Status204NoContent);

    return app;
  }

  public static WebApplication MapDeletes(this WebApplication app)
  {
    app.MapDelete("api/products/{id:int}", async (
      [FromRoute] int id,
      [FromServices] NorthwindContext db) =>
    {
      if (await db.Products.FindAsync(id) is Product product)
      {
        db.Products.Remove(product);
        await db.SaveChangesAsync();
        return Results.NoContent();
      }
      return Results.NotFound();
    }).Produces(StatusCodes.Status404NotFound)
      .Produces(StatusCodes.Status204NoContent);

    return app;
  }

  public static IServiceCollection AddCustomCors(
  this IServiceCollection services)
  {
    services.AddCors(options =>
    {
      options.AddPolicy(name: "Northwind.Mvc.Policy",
        policy =>
        {
          policy.WithOrigins("https://localhost:5102");
        });
    });
    return services;
  }

  public static async Task UseCustomClientRateLimiting(this WebApplication app)
  {
    using (IServiceScope scope = app.Services.CreateScope())
    {
      IClientPolicyStore clientPolicyStore = scope.ServiceProvider
        .GetRequiredService<IClientPolicyStore>();

      await clientPolicyStore.SeedAsync();
    }
    app.UseClientRateLimiting();
  }
}
