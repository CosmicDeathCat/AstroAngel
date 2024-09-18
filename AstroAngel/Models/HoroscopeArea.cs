using Newtonsoft.Json;

namespace ZodiacSignDailyHoroscopeApi.Models;

public class HoroscopeArea
{
    [JsonProperty("desc")]
    public string? Desc { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }
}