using FirstAirdropFerma.Models;

namespace FirstAirdropFerma.Utils;

public class ReadActionsToWork
{
    private const string FilePath = @"./actions.txt";

    public List<Command> GetCommandList()
    {
        var commandText = File.ReadAllLines(FilePath);
        return new List<Command>();
    }
}