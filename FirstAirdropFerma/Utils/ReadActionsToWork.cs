using System.Text.Json.Nodes;
using FirstAirdropFerma.Models;
using Newtonsoft.Json;

namespace FirstAirdropFerma.Utils;

public class ReadActionsToWork
{
    private const string FilePath = @"./actions.txt";

    public static Dictionary<string, List<string>> GetCommandList()
    {
        var commandText = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(commandText);
    }
}