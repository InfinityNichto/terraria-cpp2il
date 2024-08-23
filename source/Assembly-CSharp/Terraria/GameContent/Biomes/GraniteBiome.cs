using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005F6 RID: 1526
	[global::Cpp2ILInjected.Token(Token = "0x20008EE")]
	public class GraniteBiome : MicroBiome
	{
		// Token: 0x06003D87 RID: 15751 RVA: 0x0002CFC9 File Offset: 0x0002B1C9
		[global::Cpp2ILInjected.Token(Token = "0x600460A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C8BC0", Offset = "0x7C8BC0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_22", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BiomeTileCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool CanPlace(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x0002CFCC File Offset: 0x0002B1CC
		[global::Cpp2ILInjected.Token(Token = "0x600460B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C8CA8", Offset = "0x7C8CA8", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "BuildMagmaMap", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "PlaceGranite", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "CleanupTiles", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "PlaceDecorations", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x0002CFCF File Offset: 0x0002B1CF
		[global::Cpp2ILInjected.Token(Token = "0x600460C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C8E14", Offset = "0x7C8E14", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void BuildMagmaMap(Point tileOrigin)
		{
			throw null;
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x0002CFD2 File Offset: 0x0002B1D2
		[global::Cpp2ILInjected.Token(Token = "0x600460D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C8FFC", Offset = "0x7C8FFC", Length = "0x5C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void SimulatePressure(out Rectangle effectedMapArea)
		{
			throw null;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x0002CFD5 File Offset: 0x0002B1D5
		[global::Cpp2ILInjected.Token(Token = "0x600460E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7CA200", Offset = "0x7CA200", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "PlaceGranite", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool ShouldUseLava(Point tileOrigin)
		{
			throw null;
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0002CFD8 File Offset: 0x0002B1D8
		[global::Cpp2ILInjected.Token(Token = "0x600460F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C95BC", Offset = "0x7C95BC", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraniteBiome), Member = "ShouldUseLava", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "ClearTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "liquidType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void PlaceGranite(Point tileOrigin, Rectangle magmaMapArea)
		{
			throw null;
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0002CFDB File Offset: 0x0002B1DB
		[global::Cpp2ILInjected.Token(Token = "0x6004610")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C9970", Offset = "0x7C9970", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "ClearTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void CleanupTiles(Point tileOrigin, Rectangle magmaMapArea)
		{
			throw null;
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x0002CFDE File Offset: 0x0002B1DE
		[global::Cpp2ILInjected.Token(Token = "0x6004611")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C9DB4", Offset = "0x7C9DB4", Length = "0x418")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "WithModifier", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "WithModifier", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceUncheckedStalactite", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void PlaceDecorations(Point tileOrigin, Rectangle magmaMapArea)
		{
			throw null;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x0002CFE1 File Offset: 0x0002B1E1
		[global::Cpp2ILInjected.Token(Token = "0x6004612")]
		[global::Cpp2ILInjected.Address(RVA = "0x7CA3EC", Offset = "0x7CA3EC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GraniteBiome()
		{
			throw null;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x0002CFE4 File Offset: 0x0002B1E4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004613")]
		[global::Cpp2ILInjected.Address(RVA = "0x7CA47C", Offset = "0x7CA47C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static GraniteBiome()
		{
			throw null;
		}

		// Token: 0x04006BFB RID: 27643
		[global::Cpp2ILInjected.Token(Token = "0x400825B")]
		private const int MAX_MAGMA_ITERATIONS = 300;

		// Token: 0x04006BFC RID: 27644
		[global::Cpp2ILInjected.Token(Token = "0x400825C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private GraniteBiome.Magma[,] _sourceMagmaMap;

		// Token: 0x04006BFD RID: 27645
		[global::Cpp2ILInjected.Token(Token = "0x400825D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private GraniteBiome.Magma[,] _targetMagmaMap;

		// Token: 0x04006BFE RID: 27646
		[global::Cpp2ILInjected.Token(Token = "0x400825E")]
		private static Vector2D[] _normalisedVectors;

		// Token: 0x02000A02 RID: 2562
		[global::Cpp2ILInjected.Token(Token = "0x20008EF")]
		private struct Magma
		{
			// Token: 0x06004F55 RID: 20309 RVA: 0x0003002F File Offset: 0x0002E22F
			[global::Cpp2ILInjected.Token(Token = "0x6004614")]
			[global::Cpp2ILInjected.Address(RVA = "0x7CA684", Offset = "0x7CA684", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private Magma(double pressure, double resistance, bool active)
			{
				throw null;
			}

			// Token: 0x06004F56 RID: 20310 RVA: 0x00030032 File Offset: 0x0002E232
			[global::Cpp2ILInjected.Token(Token = "0x6004615")]
			[global::Cpp2ILInjected.Address(RVA = "0x7CA1DC", Offset = "0x7CA1DC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public GraniteBiome.Magma ToFlow()
			{
				throw null;
			}

			// Token: 0x06004F57 RID: 20311 RVA: 0x00030035 File Offset: 0x0002E235
			[global::Cpp2ILInjected.Token(Token = "0x6004616")]
			[global::Cpp2ILInjected.Address(RVA = "0x7CA1F0", Offset = "0x7CA1F0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static GraniteBiome.Magma CreateFlow(double pressure, double resistance = 0.0)
			{
				throw null;
			}

			// Token: 0x06004F58 RID: 20312 RVA: 0x00030038 File Offset: 0x0002E238
			[global::Cpp2ILInjected.Token(Token = "0x6004617")]
			[global::Cpp2ILInjected.Address(RVA = "0x7CA1CC", Offset = "0x7CA1CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static GraniteBiome.Magma CreateEmpty(double resistance = 0.0)
			{
				throw null;
			}

			// Token: 0x04008D13 RID: 36115
			[global::Cpp2ILInjected.Token(Token = "0x400825F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly double Pressure;

			// Token: 0x04008D14 RID: 36116
			[global::Cpp2ILInjected.Token(Token = "0x4008260")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly double Resistance;

			// Token: 0x04008D15 RID: 36117
			[global::Cpp2ILInjected.Token(Token = "0x4008261")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool IsActive;
		}
	}
}
