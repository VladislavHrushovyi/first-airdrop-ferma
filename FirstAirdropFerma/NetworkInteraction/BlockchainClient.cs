using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace FirstAirdropFerma.NetworkInteraction;

public class BlockchainClient
{
    private readonly Account _account;
    private readonly Web3 _web3;

    public BlockchainClient(string privateKey, string rpcUrl)
    {
        _account = new Account(privateKey);
        _web3 = new Web3(_account, rpcUrl);
    }

    public async Task ExecuteRawTransaction(string TxData)
    {
        
    }
}