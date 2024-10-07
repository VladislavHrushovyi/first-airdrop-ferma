namespace FirstAirdropFerma.NetworkInteraction.HttpClientFactory;

public class DefaultHttpClient : BaseHttpClient
{
    public DefaultHttpClient(string baseAddress)
    {
        HttpClient = new HttpClient();
        SetDefaultHeaders();
    }
}