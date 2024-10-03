using FirstAirdropFerma.NetworkInteraction.HttpClientFactory;
using FirstAirdropFerma.NetworkInteraction.HttpInteraction;

namespace FirstAirdropFerma.Scenarios;

public class DarenScenario
{
    private readonly DarenClient _darenClient;
    
    public DarenScenario()
    {
        var httpClient = HttpClientFactory.CreateHttpClient("Daren-Url");
        _darenClient = new DarenClient(httpClient);
    }
    public async Task Execute()
    {
        await Task.Delay(2000);
    }
}