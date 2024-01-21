using System;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003DD")]
public class WorldFileData : FileData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400338C")]
	public int _glitchFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400338D")]
	public int _glitchFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400338E")]
	public int _glitchVariation;

	[Cpp2IlInjected.Token(Token = "0x400338F")]
	private const ulong GUID_IN_WORLD_FILE_VERSION = 777389080577uL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4003390")]
	public bool CurrentSaveFormat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4003391")]
	public DateTime CreationTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4003392")]
	public int WorldSizeX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4003393")]
	public int WorldSizeY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4003394")]
	public ulong WorldGeneratorVersion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4003395")]
	private string _seedText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4003396")]
	private int _seed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4003397")]
	public bool IsValid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4003398")]
	public Guid UniqueId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4003399")]
	public LocalizedText _worldSizeName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400339A")]
	public int GameMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400339B")]
	public bool DrunkWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
	[Cpp2IlInjected.Token(Token = "0x400339C")]
	public bool NotTheBees;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
	[Cpp2IlInjected.Token(Token = "0x400339D")]
	public bool ForTheWorthy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F")]
	[Cpp2IlInjected.Token(Token = "0x400339E")]
	public bool Anniversary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400339F")]
	public bool DontStarve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
	[Cpp2IlInjected.Token(Token = "0x40033A0")]
	public bool RemixWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
	[Cpp2IlInjected.Token(Token = "0x40033A1")]
	public bool NoTrapsWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x73")]
	[Cpp2IlInjected.Token(Token = "0x40033A2")]
	public bool ZenithWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40033A3")]
	public bool HasCorruption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
	[Cpp2IlInjected.Token(Token = "0x40033A4")]
	public bool IsHardMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x76")]
	[Cpp2IlInjected.Token(Token = "0x40033A5")]
	public bool DefeatedMoonlord;

	[Cpp2IlInjected.Token(Token = "0x17000601")]
	public string SeedText
	{
		[Cpp2IlInjected.Token(Token = "0x600305B")]
		[Cpp2IlInjected.Address(RVA = "0x1252ED0", Offset = "0x1252ED0", VA = "0x1252ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000602")]
	public int Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600305C")]
		[Cpp2IlInjected.Address(RVA = "0x1252ED8", Offset = "0x1252ED8", VA = "0x1252ED8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000603")]
	public string WorldSizeName
	{
		[Cpp2IlInjected.Token(Token = "0x600305D")]
		[Cpp2IlInjected.Address(RVA = "0x1252EE0", Offset = "0x1252EE0", VA = "0x1252EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000604")]
	public bool HasCrimson
	{
		[Cpp2IlInjected.Token(Token = "0x600305E")]
		[Cpp2IlInjected.Address(RVA = "0x1252EEC", Offset = "0x1252EEC", VA = "0x1252EEC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600305F")]
		[Cpp2IlInjected.Address(RVA = "0x1252EFC", Offset = "0x1252EFC", VA = "0x1252EFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000605")]
	public bool HasValidSeed
	{
		[Cpp2IlInjected.Token(Token = "0x6003060")]
		[Cpp2IlInjected.Address(RVA = "0x1252F08", Offset = "0x1252F08", VA = "0x1252F08")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000606")]
	public bool UseGuidAsMapName
	{
		[Cpp2IlInjected.Token(Token = "0x6003061")]
		[Cpp2IlInjected.Address(RVA = "0x1252F18", Offset = "0x1252F18", VA = "0x1252F18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003062")]
	[Cpp2IlInjected.Address(RVA = "0x1252F30", Offset = "0x1252F30", VA = "0x1252F30")]
	public string GetWorldName(bool allowCropping = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003063")]
	[Cpp2IlInjected.Address(RVA = "0x1252F38", Offset = "0x1252F38", VA = "0x1252F38")]
	public string GetFullSeedText(bool allowCropping = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003064")]
	[Cpp2IlInjected.Address(RVA = "0x1253144", Offset = "0x1253144", VA = "0x1253144")]
	public WorldFileData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003065")]
	[Cpp2IlInjected.Address(RVA = "0x12531C4", Offset = "0x12531C4", VA = "0x12531C4")]
	public WorldFileData(string path, bool cloudSave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003066")]
	[Cpp2IlInjected.Address(RVA = "0x125327C", Offset = "0x125327C", VA = "0x125327C", Slot = "4")]
	public override void SetAsActive()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003067")]
	[Cpp2IlInjected.Address(RVA = "0x12532F8", Offset = "0x12532F8", VA = "0x12532F8")]
	public void SetWorldSize(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003068")]
	[Cpp2IlInjected.Address(RVA = "0x12533CC", Offset = "0x12533CC", VA = "0x12533CC")]
	public static WorldFileData FromInvalidWorld(string path, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003069")]
	[Cpp2IlInjected.Address(RVA = "0x1253568", Offset = "0x1253568", VA = "0x1253568")]
	public void SetSeedToEmpty()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600306A")]
	[Cpp2IlInjected.Address(RVA = "0x12535C4", Offset = "0x12535C4", VA = "0x12535C4")]
	public void SetSeed(string seedText)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600306B")]
	[Cpp2IlInjected.Address(RVA = "0x12536F4", Offset = "0x12536F4", VA = "0x12536F4")]
	public void SetSeedToRandom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600306C")]
	[Cpp2IlInjected.Address(RVA = "0x1253788", Offset = "0x1253788", VA = "0x1253788", Slot = "5")]
	public override void MoveToCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600306D")]
	[Cpp2IlInjected.Address(RVA = "0x12538C0", Offset = "0x12538C0", VA = "0x12538C0", Slot = "6")]
	public override void MoveToLocal()
	{
	}
}
