using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D3")]
public static class Player_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x40032BD")]
	private const int VERSION_1 = 1;

	[Cpp2IlInjected.Token(Token = "0x40032BE")]
	private const int VERSION_2 = 2;

	[Cpp2IlInjected.Token(Token = "0x40032BF")]
	private const int VERSION_3 = 3;

	[Cpp2IlInjected.Token(Token = "0x40032C0")]
	private const int VERSION_4 = 4;

	[Cpp2IlInjected.Token(Token = "0x40032C1")]
	private const int VERSION_7 = 7;

	[Cpp2IlInjected.Token(Token = "0x40032C2")]
	private const int VERSION_9 = 9;

	[Cpp2IlInjected.Token(Token = "0x40032C3")]
	private const int VERSION_10 = 10;

	[Cpp2IlInjected.Token(Token = "0x40032C4")]
	private const int VERSION_11 = 11;

	[Cpp2IlInjected.Token(Token = "0x40032C5")]
	private const int VERSION_12 = 12;

	[Cpp2IlInjected.Token(Token = "0x40032C6")]
	private const int VERSION_13 = 13;

	[Cpp2IlInjected.Token(Token = "0x40032C7")]
	private const int VERSION_14 = 14;

	[Cpp2IlInjected.Token(Token = "0x40032C8")]
	private const int VERSION_15 = 15;

	[Cpp2IlInjected.Token(Token = "0x40032C9")]
	private const int VERSION_16 = 16;

	[Cpp2IlInjected.Token(Token = "0x40032CA")]
	private const int VERSION_17 = 17;

	[Cpp2IlInjected.Token(Token = "0x40032CB")]
	private const int VERSION_18 = 18;

	[Cpp2IlInjected.Token(Token = "0x40032CC")]
	private const int VERSION_19 = 19;

	[Cpp2IlInjected.Token(Token = "0x40032CD")]
	private const int VERSION_20 = 20;

	[Cpp2IlInjected.Token(Token = "0x40032CE")]
	private const int VERSION_21 = 21;

	[Cpp2IlInjected.Token(Token = "0x40032CF")]
	private const int VERSION_22 = 22;

	[Cpp2IlInjected.Token(Token = "0x40032D0")]
	private const int VERSION_23 = 23;

	[Cpp2IlInjected.Token(Token = "0x40032D1")]
	private const int VERSION_24 = 24;

	[Cpp2IlInjected.Token(Token = "0x40032D2")]
	private const int VERSION_CURRENT = 24;

	[Cpp2IlInjected.Token(Token = "0x40032D3")]
	private const int PLAYER_DATA_VERSION = 24;

	[Cpp2IlInjected.Token(Token = "0x40032D4")]
	private static BlowFish playerDecrypter;

	[Cpp2IlInjected.Token(Token = "0x40032D5")]
	private static byte[] inputData;

	[Cpp2IlInjected.Token(Token = "0x6002FE1")]
	[Cpp2IlInjected.Address(RVA = "0xE435AC", Offset = "0xE435AC", VA = "0xE435AC")]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE2")]
	[Cpp2IlInjected.Address(RVA = "0xE4475C", Offset = "0xE4475C", VA = "0xE4475C")]
	private static void DecryptPlayerData(long offset, long encryptedSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE3")]
	[Cpp2IlInjected.Address(RVA = "0xE44908", Offset = "0xE44908", VA = "0xE44908")]
	private static bool IsValidBuff(int buffType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE4")]
	[Cpp2IlInjected.Address(RVA = "0xE449C4", Offset = "0xE449C4", VA = "0xE449C4")]
	private static void GivePlayerCoins(Player player, int value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE5")]
	[Cpp2IlInjected.Address(RVA = "0xE44D9C", Offset = "0xE44D9C", VA = "0xE44D9C")]
	private static bool LoadOld(BinaryReader reader, int release, ref Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE6")]
	[Cpp2IlInjected.Address(RVA = "0xE43904", Offset = "0xE43904", VA = "0xE43904")]
	private static bool Load(BinaryReader reader, ref Player player)
	{
		return default(bool);
	}
}
