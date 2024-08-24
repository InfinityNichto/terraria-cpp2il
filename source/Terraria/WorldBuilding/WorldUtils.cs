using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Generation;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200036E RID: 878
	[global::Cpp2ILInjected.Token(Token = "0x20004EF")]
	public static class WorldUtils
	{
		// Token: 0x06002C86 RID: 11398 RVA: 0x00029FB7 File Offset: 0x000281B7
		[global::Cpp2ILInjected.Token(Token = "0x6003094")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FEE9C", Offset = "0x12FEE9C", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Rectangle ClampToWorld(Rectangle tileRectangle)
		{
			throw null;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00029FBA File Offset: 0x000281BA
		[global::Cpp2ILInjected.Token(Token = "0x6003095")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF010", Offset = "0x12FF010", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 94)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Gen(Point origin, GenShape shape, GenAction action)
		{
			throw null;
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00029FBD File Offset: 0x000281BD
		[global::Cpp2ILInjected.Token(Token = "0x6003096")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF028", Offset = "0x12FF028", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Gen(Point origin, GenShapeActionPair pair)
		{
			throw null;
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00029FC0 File Offset: 0x000281C0
		[global::Cpp2ILInjected.Token(Token = "0x6003097")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF040", Offset = "0x12FF040", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool Find(Point origin, GenSearch search, out Point result)
		{
			throw null;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00029FC3 File Offset: 0x000281C3
		[global::Cpp2ILInjected.Token(Token = "0x6003098")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F4798", Offset = "0x12F4798", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.ClearTile), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldUtils), Member = "ClearChestLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceGranite", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "CleanupTiles", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearTile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ClearTile(int x, int y, bool frameNeighbors = false)
		{
			throw null;
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00029FC6 File Offset: 0x000281C6
		[global::Cpp2ILInjected.Token(Token = "0x6003099")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F493C", Offset = "0x12F493C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.ClearWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ClearWall(int x, int y, bool frameNeighbors = false)
		{
			throw null;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00029FC9 File Offset: 0x000281C9
		[global::Cpp2ILInjected.Token(Token = "0x600309A")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F4C80", Offset = "0x12F4C80", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTile), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetTileKeepWall), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Actions.SetFrames), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertBiome), Member = "CleanupArea", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "PlaceSlab", MemberParameters = new object[]
		{
			"Terraria.GameContent.Biomes.MarbleBiome.Slab",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void TileFrame(int x, int y, bool frameNeighbors = false)
		{
			throw null;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00029FCC File Offset: 0x000281CC
		[global::Cpp2ILInjected.Token(Token = "0x600309B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF108", Offset = "0x12FF108", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "ClearTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public static void ClearChestLocation(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00029FCF File Offset: 0x000281CF
		[global::Cpp2ILInjected.Token(Token = "0x600309C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF160", Offset = "0x12FF160", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceStatueTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceWire", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void WireLine(Point start, Point end)
		{
			throw null;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00029FD2 File Offset: 0x000281D2
		[global::Cpp2ILInjected.Token(Token = "0x600309D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF2D8", Offset = "0x12FF2D8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DebugRegen()
		{
			throw null;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00029FD5 File Offset: 0x000281D5
		[global::Cpp2ILInjected.Token(Token = "0x600309E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FF394", Offset = "0x12FF394", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DebugRotate()
		{
			throw null;
		}
	}
}
