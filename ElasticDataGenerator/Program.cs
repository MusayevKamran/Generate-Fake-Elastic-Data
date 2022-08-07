using ElasticDataGenerator.AppSettings;
using ElasticDataGenerator.Configurations;
using ElasticDataGenerator.Generators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterSettings();

builder.Services.AddElasticSearch();

var app = builder.Build();

using var scope = app.Services.CreateScope();

app.MapGet("/", async () =>  await new CustomLogDataGenerator(app.Services.CreateScope().ServiceProvider).GenerateAsync());

app.Run();
