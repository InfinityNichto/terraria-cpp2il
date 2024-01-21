using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000230")]
internal class WorldFile_OldConsole
{
	[Cpp2IlInjected.Token(Token = "0x4001B3F")]
	public const int WorldVersion_AddGUID = 1000;

	[Cpp2IlInjected.Token(Token = "0x4001B40")]
	public const int WorldVersion_CompressWorld = 1001;

	[Cpp2IlInjected.Token(Token = "0x4001B41")]
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	[Cpp2IlInjected.Token(Token = "0x4001B42")]
	public const int WorldVersion_1_3_2 = 1003;

	[Cpp2IlInjected.Token(Token = "0x4001B43")]
	public const int WorldVersion_1_3_3 = 1004;

	[Cpp2IlInjected.Token(Token = "0x4001B44")]
	public const int WorldVersion_1_3_4 = 1005;

	[Cpp2IlInjected.Token(Token = "0x4001B45")]
	public const int WorldVersion_RemapConsoleSpecificItems = 1006;

	[Cpp2IlInjected.Token(Token = "0x4001B46")]
	public const int WorldVersionOneMaxRelease = 87;

	[Cpp2IlInjected.Token(Token = "0x4001B47")]
	public const int WorldFileVersion = 1006;

	[Cpp2IlInjected.Token(Token = "0x4001B48")]
	public const int ApproximateWriteSize = 7000000;

	[Cpp2IlInjected.Token(Token = "0x4001B49")]
	public const int MaximumWriteSize = 16777216;

	[Cpp2IlInjected.Token(Token = "0x4001B4A")]
	private static int versionNumber;

	[Cpp2IlInjected.Token(Token = "0x6000FAD")]
	[Cpp2IlInjected.Address(RVA = "0xE8F564", Offset = "0xE8F564", VA = "0xE8F564")]
	public static WorldFileData GetAllMetadata(string file)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FAE")]
	[Cpp2IlInjected.Address(RVA = "0xE90630", Offset = "0xE90630", VA = "0xE90630")]
	public static byte[] DecompressData(byte[] srcData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FAF")]
	[Cpp2IlInjected.Address(RVA = "0xE90948", Offset = "0xE90948", VA = "0xE90948")]
	public static bool LoadSaveData(byte[] srcData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB0")]
	[Cpp2IlInjected.Address(RVA = "0xE94708", Offset = "0xE94708", VA = "0xE94708")]
	private static void CleanItemsStoredInTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB1")]
	[Cpp2IlInjected.Address(RVA = "0xE94864", Offset = "0xE94864", VA = "0xE94864")]
	private static void CheckWeaponsRack(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB2")]
	[Cpp2IlInjected.Address(RVA = "0xE95424", Offset = "0xE95424", VA = "0xE95424")]
	public static bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB3")]
	[Cpp2IlInjected.Address(RVA = "0xE95484", Offset = "0xE95484", VA = "0xE95484")]
	public static void PlaceWeapon(int x, int y, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB4")]
	[Cpp2IlInjected.Address(RVA = "0xE94CA8", Offset = "0xE94CA8", VA = "0xE94CA8")]
	private static void CheckMannequin(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB5")]
	[Cpp2IlInjected.Address(RVA = "0xE94374", Offset = "0xE94374", VA = "0xE94374")]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB6")]
	[Cpp2IlInjected.Address(RVA = "0xE9A5FC", Offset = "0xE9A5FC", VA = "0xE9A5FC")]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB7")]
	[Cpp2IlInjected.Address(RVA = "0xE9A798", Offset = "0xE9A798", VA = "0xE9A798")]
	private static void LoadTownManager(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB8")]
	[Cpp2IlInjected.Address(RVA = "0xE99F2C", Offset = "0xE99F2C", VA = "0xE99F2C")]
	private static void LoadTileEntities(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FB9")]
	[Cpp2IlInjected.Address(RVA = "0xE9583C", Offset = "0xE9583C", VA = "0xE9583C")]
	private static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBA")]
	[Cpp2IlInjected.Address(RVA = "0xE95B70", Offset = "0xE95B70", VA = "0xE95B70")]
	private static void LoadHeader(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBB")]
	[Cpp2IlInjected.Address(RVA = "0xE97CD8", Offset = "0xE97CD8", VA = "0xE97CD8")]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBC")]
	[Cpp2IlInjected.Address(RVA = "0xE99230", Offset = "0xE99230", VA = "0xE99230")]
	private static void LoadChests(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBD")]
	[Cpp2IlInjected.Address(RVA = "0xE9A9C0", Offset = "0xE9A9C0", VA = "0xE9A9C0")]
	private static void FixDresserChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBE")]
	[Cpp2IlInjected.Address(RVA = "0xE99790", Offset = "0xE99790", VA = "0xE99790")]
	private static void LoadSigns(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FBF")]
	[Cpp2IlInjected.Address(RVA = "0xE99ECC", Offset = "0xE99ECC", VA = "0xE99ECC")]
	private static void LoadDummies(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC0")]
	[Cpp2IlInjected.Address(RVA = "0xE99B74", Offset = "0xE99B74", VA = "0xE99B74")]
	private static void LoadNPCs(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC1")]
	[Cpp2IlInjected.Address(RVA = "0xE9A820", Offset = "0xE9A820", VA = "0xE9A820")]
	private static int LoadFooter(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC2")]
	[Cpp2IlInjected.Address(RVA = "0xE90C08", Offset = "0xE90C08", VA = "0xE90C08")]
	public static int LoadWorld_Version1(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC3")]
	[Cpp2IlInjected.Address(RVA = "0xE9A938", Offset = "0xE9A938", VA = "0xE9A938")]
	private static int ReadItemID(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FC4")]
	[Cpp2IlInjected.Address(RVA = "0xE9ABA0", Offset = "0xE9ABA0", VA = "0xE9ABA0")]
	public WorldFile_OldConsole()
	{
	}
}
