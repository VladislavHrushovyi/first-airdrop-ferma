namespace WebInteracting.HttpClientFactory;

public class HttpClientFactory
{
    public static HttpClient CreateHttpClient(string baseUrl, string? proxy = null)
    {
        if (proxy == null)
        {
            return new DefaultHttpClient("").HttpClient;
        }else
        {
            return new HttpClientWithProxy("", proxy).HttpClient;
        }
    }
}