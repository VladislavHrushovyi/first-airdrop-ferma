using FirstAirdropFerma.NetworkInteraction.HttpClientFactory;
using FirstAirdropFerma.NetworkInteraction.HttpInteraction;

namespace FirstAirdropFerma.Scenarios;

public class DarenScenario
{
    private readonly DarenClient _darenClient;
    private readonly List<string> _actions;
    public DarenScenario(List<string> actions)
    {
        _actions = actions;
        var httpClient = HttpClientFactory.CreateHttpClient("Daren-Url");
        _darenClient = new DarenClient(httpClient);
    }
    public async Task Execute()
    {
        if (_actions.Contains("daily-checkin"))
        {
            await _darenClient.DailyCheckIn();
            Console.WriteLine("Daren daily checkin");
        }
    }
}