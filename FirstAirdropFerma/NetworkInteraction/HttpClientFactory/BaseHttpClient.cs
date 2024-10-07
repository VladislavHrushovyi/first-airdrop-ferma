namespace FirstAirdropFerma.NetworkInteraction.HttpClientFactory;

public class BaseHttpClient
{
    public HttpClient HttpClient { get; set; }
    
    public void SetDefaultHeaders()
    {
        HttpClient.DefaultRequestHeaders.Add("Accept", new []{"application/json", "text/plain", "*/*"});
        HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36");
    }
}