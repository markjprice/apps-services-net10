using Northwind.EntityModels; // To use the AddNorthwindContext method.
using Northwind.WebApi.Service.Extensions; // To use MapGets and so on.
using Scalar.AspNetCore; // To use MapScalarApiReference method.

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(defaultScheme: "Bearer")
  .AddJwtBearer();

builder.Services.AddCustomRateLimiting(builder.Configuration);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddNorthwindContext();

builder.Services.AddCustomHttpLogging();

builder.Services.AddCustomCors();

var app = builder.Build();

app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
  app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseHttpLogging();

await app.UseCustomClientRateLimiting();

// app.UseCors(policyName: "Northwind.Mvc.Policy");
// Without a named policy the middleware is added but not active.
app.UseCors();

app.MapGets() // Default pageSize: 10.
  .MapPosts()
  .MapPuts()
  .MapDeletes();

app.Run();
