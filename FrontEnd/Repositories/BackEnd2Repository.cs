namespace FrontEnd;

public class BackEnd2Repository 
{
    private readonly HttpClient _httpClient;

    public BackEnd2Repository(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<int> GetBackEnd2Data()
    {
        var response = await _httpClient.GetFromJsonAsync<int>("http://localhost:5211/api/BackEnd2");
        return response;
    }

}