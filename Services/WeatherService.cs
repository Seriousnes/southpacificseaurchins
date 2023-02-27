using System.Net.Http.Json;

namespace SouthPacificSeaUrchins.Services;

public interface IWeatherService
{
    Task<WeatherResponse> GetWeatherAsync();
    WeatherResponse GetWeather();
}


public class WeatherService : IWeatherService
{
    private static readonly HttpClient _httpClient = new HttpClient() { BaseAddress = new Uri("https://api.open-meteo.com/") };

    public async Task<WeatherResponse> GetWeatherAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<WeatherResponse>("v1/forecast/?latitude=-33.87&longitude=151.21&current_weather=true&timezone=Australia%2FSydney");
        return response;
    }

    public WeatherResponse GetWeather() => GetWeatherAsync().Result;
}