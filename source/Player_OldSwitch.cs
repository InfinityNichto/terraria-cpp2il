using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000231")]
internal class Player_OldSwitch
{
	[Cpp2IlInjected.Token(Token = "0x4001B4B")]
	private const int PlayerFileVersion_GUID = 1000;

	[Cpp2IlInjected.Token(Token = "0x4001B4C")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	[Cpp2IlInjected.Token(Token = "0x4001B4D")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	[Cpp2IlInjected.Token(Token = "0x4001B4E")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	[Cpp2IlInjected.Token(Token = "0x4001B4F")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	[Cpp2IlInjected.Token(Token = "0x4001B50")]
	public static byte[] EncryptionKey;

	[Cpp2IlInjected.Token(Token = "0x6000FC5")]
	[Cpp2IlInjected.Address(RVA = "0x10B9D68", Offset = "0x10B9D68", VA = "0x10B9D68")]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC6")]
	[Cpp2IlInjected.Address(RVA = "0x10B9D88", Offset = "0x10B9D88", VA = "0x10B9D88")]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC7")]
	[Cpp2IlInjected.Address(RVA = "0x10BBE14", Offset = "0x10BBE14", VA = "0x10BBE14")]
	private static void GivePlayerCoins(Player player, int value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC8")]
	[Cpp2IlInjected.Address(RVA = "0x10BC1EC", Offset = "0x10BC1EC", VA = "0x10BC1EC")]
	public Player_OldSwitch()
	{
	}
}
