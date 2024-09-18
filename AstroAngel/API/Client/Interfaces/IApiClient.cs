namespace DLS.Api.Utilities.API.Client.Interfaces;

public interface IApiClient<T>
{
    Task<T> GetAsync(string query);
}
