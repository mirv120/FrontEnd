namespace FrontEnd;

public class BackEnd1Repository 
{
    private readonly HttpClient _httpClient;
    public BackEnd1Repository(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<int> GetBackEnd1Data()
    {
        var response = await _httpClient.GetFromJsonAsync<int>("http://localhost:5087/api/BackEnd1");
        return response;
    }

}
