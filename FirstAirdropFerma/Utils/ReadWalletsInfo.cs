using FirstAirdropFerma.Models;

namespace FirstAirdropFerma.Utils;

public class ReadWalletsInfo
{
    private const string FilePath = @"./wallets.txt";

    public static List<WalletInfo> GetWalletList()
    {
        var walletLines = File.ReadAllLines(FilePath);
        return walletLines.Select(x => x.Trim())
            .Select(x => x.Split(';'))
            .Select(x => new WalletInfo() { Address = x[0], PrivateKey = x[1], SeedPhrase = x[2] })
            .ToList();
    }
}