using System;
using MultiTenant;

namespace MultiTenantIoc.Interfaces
{
    public interface IWeatherForecastService
    {
        string Continent { get; }

        string[] GetSummaries() => new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        Task<IEnumerable<WeatherForecast>> GetWeatherForecast();
    }
}
