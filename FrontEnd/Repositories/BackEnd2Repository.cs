namespace FrontEnd;

public class BackEnd2Repository : IBackEnd2Repository
{
    private readonly HttpClient _httpClient;
    private readonly string _url;

    public BackEnd2Repository(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _url = configuration.GetConnectionString("BackEnd2") ?? throw new ArgumentNullException(nameof(configuration));
    }

    public async Task<int> GetBackEnd2Data()
    {
        var response = await _httpClient.GetFromJsonAsync<int>(_url);
        return response;
    }

    public async Task WriteBackEnd2Data(int valueToPost)
    {
         await _httpClient.PostAsJsonAsync(_url, valueToPost);
    }

}