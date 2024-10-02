namespace FirstAirdropFerma.Utils;

public class ProxyProvider
{
    private const string FilePath = @"./proxy.txt";
    public static Dictionary<string, bool> ProxyMap { get; } = new();

    static ProxyProvider()
    {
        var proxyLines = File.ReadAllLines(FilePath);

        foreach (var proxy in proxyLines)
        {
            if (string.IsNullOrWhiteSpace(proxy))
            {
                ProxyMap.Add(proxy, false);
            }
        }
    }
}