namespace FirstAirdropFerma.NetworkInteraction.HttpInteraction;

public class DarenClient(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task DailyCheckIn()
    {
        var uri = new Uri("/v2/tasks/+/DAILY_CHECK_IN/claim");
        var response = await _httpClient.GetAsync(uri);
    }
}