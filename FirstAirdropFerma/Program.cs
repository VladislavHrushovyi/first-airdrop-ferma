
using FirstAirdropFerma.Utils;

var commands = ReadActionsToWork.GetCommandList();
Console.WriteLine(commands["daren"][0]);
var wallets = ReadWalletsInfo.GetWalletList();

/*
 * 1.[] Get tokens from faucet
 */