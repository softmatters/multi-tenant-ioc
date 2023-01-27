using MultiTenantIoc.Interfaces;
using MultiTenantIoc.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

// add multiple implementations of the same interface
services
    .AddScoped<IWeatherForecastService, AsianWeatherForecastService>()
    .AddScoped<IWeatherForecastService, OceanaWeatherForecastService>();

services
    .AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
