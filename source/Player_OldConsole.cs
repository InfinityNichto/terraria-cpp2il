using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x200022F")]
internal class Player_OldConsole
{
	[Cpp2IlInjected.Token(Token = "0x4001B39")]
	private const int PlayerFileVersion_GUID = 1000;

	[Cpp2IlInjected.Token(Token = "0x4001B3A")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	[Cpp2IlInjected.Token(Token = "0x4001B3B")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	[Cpp2IlInjected.Token(Token = "0x4001B3C")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	[Cpp2IlInjected.Token(Token = "0x4001B3D")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	[Cpp2IlInjected.Token(Token = "0x4001B3E")]
	public static byte[] EncryptionKey;

	[Cpp2IlInjected.Token(Token = "0x6000FA8")]
	[Cpp2IlInjected.Address(RVA = "0x10B6FC8", Offset = "0x10B6FC8", VA = "0x10B6FC8")]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FA9")]
	[Cpp2IlInjected.Address(RVA = "0x10B7004", Offset = "0x10B7004", VA = "0x10B7004")]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FAA")]
	[Cpp2IlInjected.Address(RVA = "0x10B98EC", Offset = "0x10B98EC", VA = "0x10B98EC")]
	private static void GivePlayerCoins(Player player, int value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FAB")]
	[Cpp2IlInjected.Address(RVA = "0x10B9CC4", Offset = "0x10B9CC4", VA = "0x10B9CC4")]
	public Player_OldConsole()
	{
	}
}
