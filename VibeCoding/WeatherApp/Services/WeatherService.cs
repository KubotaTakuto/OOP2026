using AIWeather.Models;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace AIWeather.Services {
    public class WeatherService {
        private readonly HttpClient _httpClient = new();

        public async Task<WeatherData?> GetWeatherAsync(double latitude, double longitude) {
            string url =　"https://api.open-meteo.com/v1/forecast" +
                          $"?latitude={latitude}" +
                          $"&longitude={longitude}" +
                           "&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m" +
                           "&daily=temperature_2m_max,temperature_2m_min,weather_code,precipitation_probability_max" +
                           "&forecast_days=7";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<WeatherData>(json);
        }
    }
}
