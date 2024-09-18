using Newtonsoft.Json;

namespace DLS.Api.Utilities.API.Client;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _apiHost;

    public ApiClient(string apiKey, string apiHost)
    {
        _httpClient = new HttpClient();
        _apiKey = apiKey;
        _apiHost = apiHost;
    }

    public async Task<T?> GetAsync<T>(string baseUrl, Dictionary<string, string> queryParams)
    {
        // Build the full query URL with parameters
        var uriBuilder = new UriBuilder(baseUrl);
        var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
        
        foreach (var param in queryParams)
        {
            query[param.Key] = param.Value;
        }

        uriBuilder.Query = query.ToString();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = uriBuilder.Uri,
            Headers =
            {
                { "x-rapidapi-key", _apiKey },
                { "x-rapidapi-host", _apiHost }
            }
        };

        var response = await _httpClient.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        throw new HttpRequestException($"Failed to retrieve data from {baseUrl}");
    }
}