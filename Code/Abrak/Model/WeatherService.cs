using Abrak.ViewModel;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherAPI;
public class WeatherService
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<WeatherData?> GetWeatherData(string cityName)
    {
        try
        {
            string jsonResponse = await GetWeatherRawAsync(cityName);
            return ParseWeatherJson(jsonResponse);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching weather data: {ex.Message}");
            return null;
        }
    }

    private static async Task<string> GetWeatherRawAsync(string city)
    {
        string apiKey = Settings_ViewModel.API_Key;
        string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}&aqi=no";

        using HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    private static WeatherData? ParseWeatherJson(string jsonResponse)
    {
        try
        {
            using JsonDocument doc = JsonDocument.Parse(jsonResponse);

            var root = doc.RootElement;

            return new WeatherData
            {
                Name = root.GetProperty("location").GetProperty("name").GetString() ?? "Unknown",
                Country = root.GetProperty("location").GetProperty("country").GetString() ?? "Unknown",
                TemperatureC = root.GetProperty("current").GetProperty("temp_c").GetDouble(),
                Condition = root.GetProperty("current").GetProperty("condition").GetProperty("text").GetString() ?? "Unknown",
                Humidity = root.GetProperty("current").GetProperty("humidity").GetInt32(),
                WindSpeedKph = root.GetProperty("current").GetProperty("wind_kph").GetDouble(),
                WindDirection = root.GetProperty("current").GetProperty("wind_dir").GetString() ?? "Unknown",
                LocalTime = root.GetProperty("location").GetProperty("localtime").GetString() ?? "Unknown"
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing weather data: {ex.Message}");
            return null;
        }
    }
}
