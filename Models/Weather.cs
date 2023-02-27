using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SouthPacificSeaUrchins.Models;

public class WeatherResponse
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    [JsonPropertyName("generationtime_ms")]
    public double GenerationTime { get; set; }
    [JsonPropertyName("utc_offset_seconds")]
    public int UtcOffset { get; set; }
    public string Timezone { get; set; }
    [JsonPropertyName("timezone_abbreviation")]
    public string TimezoneAbbreviation { get; set; }
    public double Elevation { get; set; }
    [JsonPropertyName("current_weather")]
    public Current_Weather CurrentWeather { get; set; }
}

public class Current_Weather
{
    public double Temperature { get; set; }
    public double Windspeed { get; set; }
    public double WindDirection { get; set; }
    public int WeatherCode { get; set; }
    [JsonConverter(typeof(TimeConverter))]
    public DateTime Time { get; set; }
}

public class TimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => DateTime.Parse(reader.GetString()!);
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}