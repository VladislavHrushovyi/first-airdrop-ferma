using System.Net;

namespace WebInteracting.HttpClientFactory;

public class HttpClientWithProxy : BaseHttpClient
{

    public HttpClientWithProxy(string baseAddress, string proxyLine)
    {
        var proxySplit = proxyLine.Split(":");
        var proxy = new WebProxy()
        {
            Address = new Uri($"http://{proxySplit[0]}:{proxySplit[1]}"),
            BypassProxyOnLocal = false,
            UseDefaultCredentials = false,
            
            Credentials = new NetworkCredential()
            {
                UserName = proxySplit[2],
                Password = proxySplit[3]
            }
            
        };

        var httpClientHandler = new HttpClientHandler()
        {
            Proxy = proxy
        };

        HttpClient = new HttpClient(httpClientHandler);
        SetDefaultHeaders();
    }
}