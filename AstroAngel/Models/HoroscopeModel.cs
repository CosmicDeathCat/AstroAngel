using Newtonsoft.Json;

namespace ZodiacSignDailyHoroscopeApi.Models;

public class HoroscopeModel
{
    [JsonProperty("date")]
    public string? Date { get; set; }

    [JsonProperty("horoscope")]
    public string? HoroscopeText { get; set; }

    [JsonProperty("lucky_number")]
    public int? LuckyNumber { get; set; }

    [JsonProperty("lucky_time")]
    public string? LuckyTime { get; set; }

    [JsonProperty("color")]
    public string? Color { get; set; }

    [JsonProperty("mood")]
    public string? Mood { get; set; }

    [JsonProperty("sunsign")]
    public string? SunSign { get; set; }

    [JsonProperty("areas")]
    public List<HoroscopeArea>? Areas { get; set; }
}