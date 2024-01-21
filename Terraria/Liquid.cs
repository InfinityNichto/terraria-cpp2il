using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000319")]
public class Liquid
{
	[Cpp2IlInjected.Token(Token = "0x4002264")]
	public static int skipCount;

	[Cpp2IlInjected.Token(Token = "0x4002265")]
	public static int stuckCount;

	[Cpp2IlInjected.Token(Token = "0x4002266")]
	public static int stuckAmount;

	[Cpp2IlInjected.Token(Token = "0x4002267")]
	public static int cycles;

	[Cpp2IlInjected.Token(Token = "0x4002268")]
	public static int curMaxLiquid;

	[Cpp2IlInjected.Token(Token = "0x4002269")]
	public static int numLiquid;

	[Cpp2IlInjected.Token(Token = "0x400226A")]
	public static bool stuck;

	[Cpp2IlInjected.Token(Token = "0x400226B")]
	public static bool quickFall;

	[Cpp2IlInjected.Token(Token = "0x400226C")]
	public static bool quickSettle;

	[Cpp2IlInjected.Token(Token = "0x400226D")]
	private static int wetCounter;

	[Cpp2IlInjected.Token(Token = "0x400226E")]
	public static int panicCounter;

	[Cpp2IlInjected.Token(Token = "0x400226F")]
	public static bool panicMode;

	[Cpp2IlInjected.Token(Token = "0x4002270")]
	public static int panicY;

	[Cpp2IlInjected.Token(Token = "0x4002271")]
	public const int maxLiquidBuffer = 50000;

	[Cpp2IlInjected.Token(Token = "0x4002272")]
	public static int maxLiquid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002273")]
	public int x;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002274")]
	public int y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002275")]
	public int kill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002276")]
	public int delay;

	[Cpp2IlInjected.Token(Token = "0x4002277")]
	private static HashSet<int> _netChangeSet;

	[Cpp2IlInjected.Token(Token = "0x4002278")]
	private static HashSet<int> _swapNetChangeSet;

	[Cpp2IlInjected.Token(Token = "0x6001A48")]
	[Cpp2IlInjected.Address(RVA = "0x140222C", Offset = "0x140222C", VA = "0x140222C")]
	public static void NetSendLiquid(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A49")]
	[Cpp2IlInjected.Address(RVA = "0x14023AC", Offset = "0x14023AC", VA = "0x14023AC")]
	public static void tilesIgnoreWater(bool ignoreSolids)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4A")]
	[Cpp2IlInjected.Address(RVA = "0x1402450", Offset = "0x1402450", VA = "0x1402450")]
	public static void worldGenTilesIgnoreWater(bool ignoreSolids)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4B")]
	[Cpp2IlInjected.Address(RVA = "0x1402504", Offset = "0x1402504", VA = "0x1402504")]
	public static void ReInit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4C")]
	[Cpp2IlInjected.Address(RVA = "0x1402660", Offset = "0x1402660", VA = "0x1402660")]
	public static void QuickWater(int verbose = 0, int minY = -1, int maxY = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4D")]
	[Cpp2IlInjected.Address(RVA = "0x1403BE0", Offset = "0x1403BE0", VA = "0x1403BE0")]
	private unsafe static void AttemptToMoveHoney(int X, int Y, bool tileAtXYHasHoney, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4E")]
	[Cpp2IlInjected.Address(RVA = "0x1403964", Offset = "0x1403964", VA = "0x1403964")]
	private unsafe static void AttemptToMoveLava(int X, int Y, bool tileAtXYHasLava, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1403E5C", Offset = "0x1403E5C", VA = "0x1403E5C")]
	private unsafe static void AttemptToMoveShimmer(int X, int Y, bool tileAtXYHasShimmer, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A50")]
	[Cpp2IlInjected.Address(RVA = "0x14035E8", Offset = "0x14035E8", VA = "0x14035E8")]
	private static void UpdateProgressDisplay(int verbose, int minY, int maxY, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A51")]
	[Cpp2IlInjected.Address(RVA = "0x140443C", Offset = "0x140443C", VA = "0x140443C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FDB4", Offset = "0x38FDB4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FDB4", Offset = "0x38FDB4")]
	public unsafe void Update(int worldWidth, uint* tileLookup, ushort* tileTypeData, short* tileTypeSHeader, byte* tileTypeBHeader, byte* tileLiquidValues, ushort* tileSearchUID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A52")]
	[Cpp2IlInjected.Address(RVA = "0x1407918", Offset = "0x1407918", VA = "0x1407918")]
	public static void StartPanic()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A53")]
	[Cpp2IlInjected.Address(RVA = "0x1407AEC", Offset = "0x1407AEC", VA = "0x1407AEC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FE68", Offset = "0x38FE68")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FE68", Offset = "0x38FE68")]
	public static void UpdateLiquid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A54")]
	[Cpp2IlInjected.Address(RVA = "0x1407354", Offset = "0x1407354", VA = "0x1407354")]
	public static void AddWater(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A55")]
	[Cpp2IlInjected.Address(RVA = "0x1409DA8", Offset = "0x1409DA8", VA = "0x1409DA8")]
	private static bool UnderGroundDesertCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A56")]
	[Cpp2IlInjected.Address(RVA = "0x140A06C", Offset = "0x140A06C", VA = "0x140A06C")]
	private static bool UndergroundDesertCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A57")]
	[Cpp2IlInjected.Address(RVA = "0x140A21C", Offset = "0x140A21C", VA = "0x140A21C")]
	public unsafe static void LiquidCheck(int x, int y, int thisLiquidType, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A58")]
	[Cpp2IlInjected.Address(RVA = "0x140AFC4", Offset = "0x140AFC4", VA = "0x140AFC4")]
	public static void GetLiquidMergeTypes(int thisLiquidType, out int liquidMergeTileType, out int liquidMergeType, bool waterNearby, bool lavaNearby, bool honeyNearby, bool shimmerNearby)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A59")]
	[Cpp2IlInjected.Address(RVA = "0x1404180", Offset = "0x1404180", VA = "0x1404180")]
	public unsafe static void LavaCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A5A")]
	[Cpp2IlInjected.Address(RVA = "0x14040D8", Offset = "0x14040D8", VA = "0x14040D8")]
	public unsafe static void HoneyCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A5B")]
	[Cpp2IlInjected.Address(RVA = "0x1404394", Offset = "0x1404394", VA = "0x1404394")]
	public unsafe static void ShimmerCheck(int x, int y, uint* tileLookup, byte* tileTypeBHeader, byte* tileTypeLiquid, int worldWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A5C")]
	[Cpp2IlInjected.Address(RVA = "0x1408CAC", Offset = "0x1408CAC", VA = "0x1408CAC")]
	public static void DelWater(int l)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A5D")]
	[Cpp2IlInjected.Address(RVA = "0x140B0C0", Offset = "0x140B0C0", VA = "0x140B0C0")]
	public Liquid()
	{
	}
}
