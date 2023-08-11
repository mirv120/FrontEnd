namespace FrontEnd;

public class BackEnd1Repository 
{
    private readonly HttpClient _httpClient;
    private readonly string _url;

    public BackEnd1Repository(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _url = configuration.GetConnectionString("BackEnd1") ?? throw new ArgumentNullException(nameof(configuration));
    }

    public async Task<int> GetBackEnd1Data()
    {
        var response = await _httpClient.GetFromJsonAsync<int>(_url);
        return response;
    }

    public async Task WriteBackEnd1Data(int valueToPost)
    {
         await _httpClient.PostAsJsonAsync(_url, valueToPost);
    }

}
