using DLS.Api.Utilities.API.Client;
using DLS.Api.Utilities.API.Client.Interfaces;
using ZodiacSignDailyHoroscopeApi.Models;

namespace ZodiacSignDailyHoroscopeApi.Services;

public class HoroscopeService
{
    private readonly ApiClient _apiClient;
    private readonly string _baseUrl;

    public HoroscopeService(ApiClient apiClient, string baseUrl)
    {
        _apiClient = apiClient;
        _baseUrl = baseUrl;
    }

    public async Task<HoroscopeModel?> GetHoroscope(string zodiacSign)
    {
        var queryParams = new Dictionary<string, string>
        {
            { "day", "today" },
            { "sunsign", zodiacSign }
        };

        return await _apiClient.GetAsync<HoroscopeModel>(_baseUrl, queryParams);
    }
}