using FirstAirdropFerma.Models;

namespace FirstAirdropFerma.Utils;

public class ReadActionsToWork
{
    private const string FilePath = @"./actions.txt";

    public List<Command> GetCommandList()
    {
        var commandText = File.ReadAllLines(FilePath);
        return commandText.Select(x => x.Trim())
            .Select(x => new Command(){CommandName = x})
            .ToList();
    }
}