using Northwind.GraphQL.Service; // To use Query.
using Northwind.EntityModels; // To use AddNorthwindContext method.

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddNorthwindContext();
builder.Services.AddDbContextFactory<NorthwindContext>();

builder.Services
  .AddGraphQLServer()
  .AddFiltering()
  .AddSorting()
  .AddSubscriptionType<Subscription>()
  .AddInMemorySubscriptions()
  .RegisterDbContextFactory<NorthwindContext>()
  .AddQueryType<Query>()
  .AddMutationType<Mutation>();

var app = builder.Build();

app.UseWebSockets(); // For subscriptions.

app.MapGet("/", () => "Navigate to: https://localhost:5131/graphql");

app.MapGraphQL();

app.Run();
