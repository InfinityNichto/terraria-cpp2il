using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000232")]
internal class WorldFile_OldSwitch
{
	[Cpp2IlInjected.Token(Token = "0x4001B51")]
	public const int WorldVersion_AddGUID = 1000;

	[Cpp2IlInjected.Token(Token = "0x4001B52")]
	public const int WorldVersion_CompressWorld = 1001;

	[Cpp2IlInjected.Token(Token = "0x4001B53")]
	public const int WorldVersion_StoreFrameAsRowsAndColumnsInsteadOfPixels = 1002;

	[Cpp2IlInjected.Token(Token = "0x4001B54")]
	public const int WorldVersion_RemoveSectionPointers = 1003;

	[Cpp2IlInjected.Token(Token = "0x4001B55")]
	public const int WorldVersion_1_3_2 = 1004;

	[Cpp2IlInjected.Token(Token = "0x4001B56")]
	public const int WorldVersion_1_3_3 = 1005;

	[Cpp2IlInjected.Token(Token = "0x4001B57")]
	public const int WorldVersion_1_3_4 = 1007;

	[Cpp2IlInjected.Token(Token = "0x4001B58")]
	public const int WorldVersion_RemapConsoleSpecificItems = 1008;

	[Cpp2IlInjected.Token(Token = "0x4001B59")]
	public const int WorldVersionOneMaxRelease = 87;

	[Cpp2IlInjected.Token(Token = "0x4001B5A")]
	public const int WorldFileVersion = 1008;

	[Cpp2IlInjected.Token(Token = "0x4001B5B")]
	public const int ApproximateWriteSize = 7000000;

	[Cpp2IlInjected.Token(Token = "0x4001B5C")]
	public const int MaximumWriteSize = 16777216;

	[Cpp2IlInjected.Token(Token = "0x4001B5D")]
	private static int versionNumber;

	[Cpp2IlInjected.Token(Token = "0x6000FCA")]
	[Cpp2IlInjected.Address(RVA = "0x14EFFC0", Offset = "0x14EFFC0", VA = "0x14EFFC0")]
	public static WorldFileData GetAllMetadata(string file)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FCB")]
	[Cpp2IlInjected.Address(RVA = "0x14F1148", Offset = "0x14F1148", VA = "0x14F1148")]
	public static byte[] DecompressData(byte[] srcData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FCC")]
	[Cpp2IlInjected.Address(RVA = "0x14F1460", Offset = "0x14F1460", VA = "0x14F1460")]
	public static bool LoadSaveData(byte[] srcData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FCD")]
	[Cpp2IlInjected.Address(RVA = "0x14F51E0", Offset = "0x14F51E0", VA = "0x14F51E0")]
	private static void CleanItemsStoredInTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FCE")]
	[Cpp2IlInjected.Address(RVA = "0x14F533C", Offset = "0x14F533C", VA = "0x14F533C")]
	private static void CheckWeaponsRack(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FCF")]
	[Cpp2IlInjected.Address(RVA = "0x14F5C48", Offset = "0x14F5C48", VA = "0x14F5C48")]
	public static bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD0")]
	[Cpp2IlInjected.Address(RVA = "0x14F5CA8", Offset = "0x14F5CA8", VA = "0x14F5CA8")]
	public static void PlaceWeapon(int x, int y, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD1")]
	[Cpp2IlInjected.Address(RVA = "0x14F5720", Offset = "0x14F5720", VA = "0x14F5720")]
	private static void CheckMannequin(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD2")]
	[Cpp2IlInjected.Address(RVA = "0x14F4E94", Offset = "0x14F4E94", VA = "0x14F4E94")]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD3")]
	[Cpp2IlInjected.Address(RVA = "0x14FAB0C", Offset = "0x14FAB0C", VA = "0x14FAB0C")]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD4")]
	[Cpp2IlInjected.Address(RVA = "0x14FACA8", Offset = "0x14FACA8", VA = "0x14FACA8")]
	private static void LoadTownManager(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD5")]
	[Cpp2IlInjected.Address(RVA = "0x14FA43C", Offset = "0x14FA43C", VA = "0x14FA43C")]
	private static void LoadTileEntities(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD6")]
	[Cpp2IlInjected.Address(RVA = "0x14F6060", Offset = "0x14F6060", VA = "0x14F6060")]
	private static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD7")]
	[Cpp2IlInjected.Address(RVA = "0x14F6394", Offset = "0x14F6394", VA = "0x14F6394")]
	private static void LoadHeader(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD8")]
	[Cpp2IlInjected.Address(RVA = "0x14F82A0", Offset = "0x14F82A0", VA = "0x14F82A0")]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FD9")]
	[Cpp2IlInjected.Address(RVA = "0x14F9788", Offset = "0x14F9788", VA = "0x14F9788")]
	private static void LoadChests(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDA")]
	[Cpp2IlInjected.Address(RVA = "0x14FAE58", Offset = "0x14FAE58", VA = "0x14FAE58")]
	private static void FixDresserChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDB")]
	[Cpp2IlInjected.Address(RVA = "0x14F9CA0", Offset = "0x14F9CA0", VA = "0x14F9CA0")]
	private static void LoadSigns(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDC")]
	[Cpp2IlInjected.Address(RVA = "0x14FA3DC", Offset = "0x14FA3DC", VA = "0x14FA3DC")]
	private static void LoadDummies(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDD")]
	[Cpp2IlInjected.Address(RVA = "0x14FA084", Offset = "0x14FA084", VA = "0x14FA084")]
	private static void LoadNPCs(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDE")]
	[Cpp2IlInjected.Address(RVA = "0x14FAD30", Offset = "0x14FAD30", VA = "0x14FAD30")]
	private static int LoadFooter(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FDF")]
	[Cpp2IlInjected.Address(RVA = "0x14F1720", Offset = "0x14F1720", VA = "0x14F1720")]
	public static int LoadWorld_Version1(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE0")]
	[Cpp2IlInjected.Address(RVA = "0x14FAE48", Offset = "0x14FAE48", VA = "0x14FAE48")]
	private static int ReadItemID(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FE1")]
	[Cpp2IlInjected.Address(RVA = "0x14FB038", Offset = "0x14FB038", VA = "0x14FB038")]
	public WorldFile_OldSwitch()
	{
	}
}
