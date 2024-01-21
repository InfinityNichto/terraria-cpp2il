using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D9")]
public class WorldFile_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x40032DC")]
	public const int VERSION_49 = 49;

	[Cpp2IlInjected.Token(Token = "0x40032DD")]
	public const int VERSION_50 = 50;

	[Cpp2IlInjected.Token(Token = "0x40032DE")]
	public const int VERSION_51 = 51;

	[Cpp2IlInjected.Token(Token = "0x40032DF")]
	public const int VERSION_52 = 52;

	[Cpp2IlInjected.Token(Token = "0x40032E0")]
	public const int VERSION_53 = 53;

	[Cpp2IlInjected.Token(Token = "0x40032E1")]
	public const int VERSION_54 = 54;

	[Cpp2IlInjected.Token(Token = "0x40032E2")]
	public const int VERSION_55 = 55;

	[Cpp2IlInjected.Token(Token = "0x40032E3")]
	public const int VERSION_56 = 56;

	[Cpp2IlInjected.Token(Token = "0x40032E4")]
	public const int VERSION_57 = 57;

	[Cpp2IlInjected.Token(Token = "0x40032E5")]
	public const int VERSION_58 = 58;

	[Cpp2IlInjected.Token(Token = "0x40032E6")]
	public const int VERSION_59 = 59;

	[Cpp2IlInjected.Token(Token = "0x40032E7")]
	public const int VERSION_60 = 60;

	[Cpp2IlInjected.Token(Token = "0x40032E8")]
	public const int VERSION_61 = 61;

	[Cpp2IlInjected.Token(Token = "0x40032E9")]
	public const int VERSION_62 = 62;

	[Cpp2IlInjected.Token(Token = "0x40032EA")]
	public const int VERSION_63 = 63;

	[Cpp2IlInjected.Token(Token = "0x40032EB")]
	public const int VERSION_64 = 64;

	[Cpp2IlInjected.Token(Token = "0x40032EC")]
	public const int VERSION_65 = 65;

	[Cpp2IlInjected.Token(Token = "0x40032ED")]
	public const int VERSION_66 = 66;

	[Cpp2IlInjected.Token(Token = "0x40032EE")]
	public const int VERSION_67 = 67;

	[Cpp2IlInjected.Token(Token = "0x40032EF")]
	public const int VERSION_68 = 68;

	[Cpp2IlInjected.Token(Token = "0x40032F0")]
	public const int VERSION_69 = 69;

	[Cpp2IlInjected.Token(Token = "0x40032F1")]
	public const int VERSION_70 = 70;

	[Cpp2IlInjected.Token(Token = "0x40032F2")]
	public const int VERSION_71 = 71;

	[Cpp2IlInjected.Token(Token = "0x40032F3")]
	public const int VERSION_72 = 72;

	[Cpp2IlInjected.Token(Token = "0x40032F4")]
	public const int VERSION_73 = 73;

	[Cpp2IlInjected.Token(Token = "0x40032F5")]
	public const int VERSION_CURRENT = 73;

	[Cpp2IlInjected.Token(Token = "0x40032F6")]
	public const int NEW_WORLD_DATA_VERSION = 73;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032F7")]
	private bool isCloudSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032F8")]
	private int worldID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40032F9")]
	private int worldTimestamp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40032FA")]
	private int hellLayer;

	[Cpp2IlInjected.Token(Token = "0x40032FB")]
	private static Weather_OldMobile weather;

	[Cpp2IlInjected.Token(Token = "0x40032FC")]
	private static NPCInfo_OldMobile npcInfo;

	[Cpp2IlInjected.Token(Token = "0x40032FD")]
	private static TimeInfo_OldMobile tempTime;

	[Cpp2IlInjected.Token(Token = "0x40032FE")]
	private static FishingInfo_OldMobile fishingInfo;

	[Cpp2IlInjected.Token(Token = "0x40032FF")]
	private static RandomStyleInfo_OldMobile tree;

	[Cpp2IlInjected.Token(Token = "0x4003300")]
	private static RandomStyleInfo_OldMobile caveBack;

	[Cpp2IlInjected.Token(Token = "0x4003301")]
	private static TilInfo_OldMobile tileInfo;

	[Cpp2IlInjected.Token(Token = "0x4003302")]
	private static ChestInfo_OldMobile chestInfo;

	[Cpp2IlInjected.Token(Token = "0x4003303")]
	private static SignInfo_OldMobile signInfo;

	[Cpp2IlInjected.Token(Token = "0x4003304")]
	private static BlowFish worldDecrypter;

	[Cpp2IlInjected.Token(Token = "0x4003305")]
	private static byte[] inputData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003306")]
	private int saveRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003307")]
	private uint timestamp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4003308")]
	private List<uint> timestamps;

	[Cpp2IlInjected.Token(Token = "0x6002FFD")]
	[Cpp2IlInjected.Address(RVA = "0x12539F8", Offset = "0x12539F8", VA = "0x12539F8")]
	public bool LoadSaveData(byte[] srcData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FFE")]
	[Cpp2IlInjected.Address(RVA = "0x1253CD8", Offset = "0x1253CD8", VA = "0x1253CD8")]
	private int loadWorldHeader(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FFF")]
	[Cpp2IlInjected.Address(RVA = "0x1254DC4", Offset = "0x1254DC4", VA = "0x1254DC4")]
	private static void DecryptWorldData(long offset, long encryptedSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003000")]
	[Cpp2IlInjected.Address(RVA = "0x1254F74", Offset = "0x1254F74", VA = "0x1254F74")]
	private void BadMarker(BinaryReader reader, string marker)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003001")]
	[Cpp2IlInjected.Address(RVA = "0x1253F1C", Offset = "0x1253F1C", VA = "0x1253F1C")]
	private void loadWorldData(BinaryReader reader, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003002")]
	[Cpp2IlInjected.Address(RVA = "0x1255430", Offset = "0x1255430", VA = "0x1255430")]
	public static byte[] ReadAllBytes(Stream stream)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003003")]
	[Cpp2IlInjected.Address(RVA = "0x125557C", Offset = "0x125557C", VA = "0x125557C")]
	public static WorldFileData GetAllMetadata(string file, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003004")]
	[Cpp2IlInjected.Address(RVA = "0x1255BBC", Offset = "0x1255BBC", VA = "0x1255BBC")]
	private static int loadWorldHeaderMeta(WorldFileData data, BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003005")]
	[Cpp2IlInjected.Address(RVA = "0x1255CA8", Offset = "0x1255CA8", VA = "0x1255CA8")]
	private static void loadWorldDataMeta(WorldFileData data, BinaryReader reader, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003006")]
	[Cpp2IlInjected.Address(RVA = "0x125607C", Offset = "0x125607C", VA = "0x125607C")]
	public WorldFile_OldMobile()
	{
	}
}
