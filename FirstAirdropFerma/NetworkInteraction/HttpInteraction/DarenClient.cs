namespace FirstAirdropFerma.NetworkInteraction.HttpInteraction;

public class DarenClient(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task DailyCheckIn()
    {
        await Task.Delay(2000);
    }
}