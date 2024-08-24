using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000602 RID: 1538
	[global::Cpp2ILInjected.Token(Token = "0x2000901")]
	public static class DesertHive
	{
		// Token: 0x06003DD0 RID: 15824 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		[global::Cpp2ILInjected.Token(Token = "0x600466C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D7564", Offset = "0x7D7564", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive.ClusterGroup), Member = "FromDescription", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(DesertHive.ClusterGroup))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive), Member = "PlaceClusters", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(DesertHive.ClusterGroup)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive), Member = "AddTileVariance", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		public static void Place(DesertDescription description)
		{
			throw null;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x0002D0A7 File Offset: 0x0002B2A7
		[global::Cpp2ILInjected.Token(Token = "0x600466D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D75F0", Offset = "0x7D75F0", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(DesertHive.ClusterGroup),
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void PlaceClusters(DesertDescription description, DesertHive.ClusterGroup clusters)
		{
			throw null;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x0002D0AA File Offset: 0x0002B2AA
		[global::Cpp2ILInjected.Token(Token = "0x600466E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D7D5C", Offset = "0x7D7D5C", Length = "0xB34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClusters", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(DesertHive.ClusterGroup)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "WithModifier", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_liquid", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "WithModifier", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(FastRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "lava", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "UpdateDesertHiveBounds", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private static void PlaceClustersArea(DesertDescription description, DesertHive.ClusterGroup clusters, Rectangle area, DesertHive.PostPlacementEffect[,] postEffectMap, Point postEffectMapOffset)
		{
			throw null;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x0002D0AD File Offset: 0x0002B2AD
		[global::Cpp2ILInjected.Token(Token = "0x600466F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D77BC", Offset = "0x7D77BC", Length = "0x5A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static void AddTileVariance(DesertDescription description)
		{
			throw null;
		}

		// Token: 0x02000A09 RID: 2569
		[global::Cpp2ILInjected.Token(Token = "0x2000902")]
		private struct Block
		{
			// Token: 0x06004F6E RID: 20334 RVA: 0x0003006E File Offset: 0x0002E26E
			[global::Cpp2ILInjected.Token(Token = "0x6004670")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D8890", Offset = "0x7D8890", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(void))]
			public Block(double x, double y)
			{
				throw null;
			}

			// Token: 0x04008D22 RID: 36130
			[global::Cpp2ILInjected.Token(Token = "0x400827F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2D Position;
		}

		// Token: 0x02000A0A RID: 2570
		[global::Cpp2ILInjected.Token(Token = "0x2000903")]
		private struct Cluster
		{
			// Token: 0x04008D23 RID: 36131
			[global::Cpp2ILInjected.Token(Token = "0x4008280")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Offset;

			// Token: 0x04008D24 RID: 36132
			[global::Cpp2ILInjected.Token(Token = "0x4008281")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Count;
		}

		// Token: 0x02000A0B RID: 2571
		[global::Cpp2ILInjected.Token(Token = "0x2000904")]
		private class ClusterGroup
		{
			// Token: 0x06004F6F RID: 20335 RVA: 0x00030071 File Offset: 0x0002E271
			[global::Cpp2ILInjected.Token(Token = "0x6004671")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D88C0", Offset = "0x7D88C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private ClusterGroup(int width, int height)
			{
				throw null;
			}

			// Token: 0x06004F70 RID: 20336 RVA: 0x00030074 File Offset: 0x0002E274
			[global::Cpp2ILInjected.Token(Token = "0x6004672")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D7588", Offset = "0x7D7588", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive.ClusterGroup), Member = "Generate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static DesertHive.ClusterGroup FromDescription(DesertDescription description)
			{
				throw null;
			}

			// Token: 0x06004F71 RID: 20337 RVA: 0x00030077 File Offset: 0x0002E277
			[global::Cpp2ILInjected.Token(Token = "0x6004673")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D9784", Offset = "0x7D9784", Length = "0x208")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive.ClusterGroup), Member = "SearchForCluster", MemberParameters = new object[]
			{
				typeof(bool[,,]),
				typeof(List<Point>),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive.ClusterGroup), Member = "Generate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive.ClusterGroup), Member = "SearchForCluster", MemberParameters = new object[]
			{
				typeof(bool[,,]),
				typeof(List<Point>),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private static void SearchForCluster(bool[,] blockMap, List<Point> pointCluster, int x, int y, int level = 2)
			{
				throw null;
			}

			// Token: 0x06004F72 RID: 20338 RVA: 0x0003007A File Offset: 0x0002E27A
			[global::Cpp2ILInjected.Token(Token = "0x6004674")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D998C", Offset = "0x7D998C", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive.ClusterGroup), Member = "Generate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private static void AttemptClaim(int x, int y, int[,] clusterIndexMap, List<List<Point>> pointClusters, int index)
			{
				throw null;
			}

			// Token: 0x06004F73 RID: 20339 RVA: 0x0003007D File Offset: 0x0002E27D
			[global::Cpp2ILInjected.Token(Token = "0x6004675")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D88F0", Offset = "0x7D88F0", Length = "0xE94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive.ClusterGroup), Member = "FromDescription", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(DesertHive.ClusterGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive.ClusterGroup), Member = "SearchForCluster", MemberParameters = new object[]
			{
				typeof(bool[,,]),
				typeof(List<Point>),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertHive.ClusterGroup), Member = "AttemptClaim", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int[,,]),
				typeof(List<List<Point>>),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2D>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DesertHive.Cluster>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2D>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DesertHive.Cluster>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 66)]
			private void Generate()
			{
				throw null;
			}

			// Token: 0x04008D25 RID: 36133
			[global::Cpp2ILInjected.Token(Token = "0x4008282")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly int Width;

			// Token: 0x04008D26 RID: 36134
			[global::Cpp2ILInjected.Token(Token = "0x4008283")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly int Height;

			// Token: 0x04008D27 RID: 36135
			[global::Cpp2ILInjected.Token(Token = "0x4008284")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Vector2D[] Points;

			// Token: 0x04008D28 RID: 36136
			[global::Cpp2ILInjected.Token(Token = "0x4008285")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DesertHive.Cluster[] Clusters;
		}

		// Token: 0x02000A0C RID: 2572
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000905")]
		private enum PostPlacementEffect : byte
		{
			// Token: 0x04008D2A RID: 36138
			[global::Cpp2ILInjected.Token(Token = "0x4008287")]
			None = 0,
			// Token: 0x04008D2B RID: 36139
			[global::Cpp2ILInjected.Token(Token = "0x4008288")]
			Smooth = 1
		}
	}
}
