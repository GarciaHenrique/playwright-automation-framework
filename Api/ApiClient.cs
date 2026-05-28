using RestSharp;

namespace PlaywrightFramework.Api;

public class ApiClient
{
    private readonly RestClient _client;

    public ApiClient()
    {
        _client = new RestClient(
            "https://jsonplaceholder.typicode.com");
    }

    public async Task<RestResponse> GetUsers()
    {
        var request =
            new RestRequest("/users");

        return await _client.ExecuteGetAsync(request);
    }
}