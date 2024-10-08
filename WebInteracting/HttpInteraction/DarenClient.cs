namespace WebInteracting.HttpInteraction;

public class DarenClient(HttpClient httpClient)
{
    public async Task DailyCheckIn()
    {
        var uri = new Uri("/v2/tasks/+/DAILY_CHECK_IN/claim");
        var response = await httpClient.GetAsync(uri);
    }
}