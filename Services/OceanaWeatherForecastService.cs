using System;
using MultiTenant;
using MultiTenantIoc.Interfaces;

namespace MultiTenantIoc.Services;

public class OceanaWeatherForecastService : IWeatherForecastService
{
    readonly IWeatherForecastService _self;
    public OceanaWeatherForecastService()
    {
        _self = this;
    }
    public string Continent => "Oceana";

    public Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
    {
        var summaries = _self.GetSummaries();

        var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = "Random Forecast from Oceana:" + summaries[Random.Shared.Next(summaries.Length)]
        });

        return Task.FromResult(forecasts);
    }
}
