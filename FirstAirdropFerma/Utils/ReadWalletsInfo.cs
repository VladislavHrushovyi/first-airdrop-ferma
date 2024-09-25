using FirstAirdropFerma.Models;

namespace FirstAirdropFerma.Utils;

public class ReadWalletsInfo
{
    private const string FilePath = @"./wallets.txt";

    public static List<WalletInfo> GetWalletList()
    {
        var walletLines = File.ReadAllLines(FilePath);
        return new List<WalletInfo>();
    }
}