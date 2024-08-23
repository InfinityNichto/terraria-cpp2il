using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005FB RID: 1531
	[global::Cpp2ILInjected.Token(Token = "0x20008F4")]
	public class MarbleBiome : MicroBiome
	{
		// Token: 0x06003DA8 RID: 15784 RVA: 0x0002D02C File Offset: 0x0002B22C
		[global::Cpp2ILInjected.Token(Token = "0x600462F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D1660", Offset = "0x7D1660", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome.Slab), Member = "get_IsSolid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome.SlabState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void SmoothSlope(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x0002D02F File Offset: 0x0002B22F
		[global::Cpp2ILInjected.Token(Token = "0x6004630")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D1A3C", Offset = "0x7D1A3C", Length = "0x3E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void PlaceSlab(MarbleBiome.Slab slab, int originX, int originY, int scale)
		{
			throw null;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x0002D032 File Offset: 0x0002B232
		[global::Cpp2ILInjected.Token(Token = "0x6004631")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D1E1C", Offset = "0x7D1E1C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsGroupSolid(int x, int y, int scale)
		{
			throw null;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0002D035 File Offset: 0x0002B235
		[global::Cpp2ILInjected.Token(Token = "0x6004632")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D1EFC", Offset = "0x7D1EFC", Length = "0x78C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BiomeTileCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome), Member = "IsGroupSolid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome.SlabState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarbleBiome), Member = "PlaceSlab", MemberParameters = new object[]
		{
			typeof(MarbleBiome.Slab),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override bool Place(Point origin, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x0002D038 File Offset: 0x0002B238
		[global::Cpp2ILInjected.Token(Token = "0x6004633")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D2690", Offset = "0x7D2690", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		public MarbleBiome()
		{
			throw null;
		}

		// Token: 0x04006C00 RID: 27648
		[global::Cpp2ILInjected.Token(Token = "0x4008263")]
		private const int SCALE = 3;

		// Token: 0x04006C01 RID: 27649
		[global::Cpp2ILInjected.Token(Token = "0x4008264")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MarbleBiome.Slab[,] _slabs;

		// Token: 0x02000A03 RID: 2563
		// (Invoke) Token: 0x06004F5A RID: 20314
		[global::Cpp2ILInjected.Token(Token = "0x20008F5")]
		private delegate bool SlabState(int x, int y, int scale);

		// Token: 0x02000A04 RID: 2564
		[global::Cpp2ILInjected.Token(Token = "0x20008F6")]
		private static class SlabStates
		{
			// Token: 0x06004F5D RID: 20317 RVA: 0x0003003B File Offset: 0x0002E23B
			[global::Cpp2ILInjected.Token(Token = "0x6004638")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D277C", Offset = "0x7D277C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool Empty(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x0003003E File Offset: 0x0002E23E
			[global::Cpp2ILInjected.Token(Token = "0x6004639")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D2784", Offset = "0x7D2784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool Solid(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F5F RID: 20319 RVA: 0x00030041 File Offset: 0x0002E241
			[global::Cpp2ILInjected.Token(Token = "0x600463A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D278C", Offset = "0x7D278C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool HalfBrick(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F60 RID: 20320 RVA: 0x00030044 File Offset: 0x0002E244
			[global::Cpp2ILInjected.Token(Token = "0x600463B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27A0", Offset = "0x7D27A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool BottomRightFilled(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x00030047 File Offset: 0x0002E247
			[global::Cpp2ILInjected.Token(Token = "0x600463C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27B0", Offset = "0x7D27B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool BottomLeftFilled(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F62 RID: 20322 RVA: 0x0003004A File Offset: 0x0002E24A
			[global::Cpp2ILInjected.Token(Token = "0x600463D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27BC", Offset = "0x7D27BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool TopRightFilled(int x, int y, int scale)
			{
				throw null;
			}

			// Token: 0x06004F63 RID: 20323 RVA: 0x0003004D File Offset: 0x0002E24D
			[global::Cpp2ILInjected.Token(Token = "0x600463E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27C8", Offset = "0x7D27C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool TopLeftFilled(int x, int y, int scale)
			{
				throw null;
			}
		}

		// Token: 0x02000A05 RID: 2565
		[global::Cpp2ILInjected.Token(Token = "0x20008F7")]
		private struct Slab
		{
			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00030050 File Offset: 0x0002E250
			[global::Cpp2ILInjected.Token(Token = "0x170007F0")]
			public bool IsSolid
			{
				[global::Cpp2ILInjected.Token(Token = "0x600463F")]
				[global::Cpp2ILInjected.Address(RVA = "0x7D18E4", Offset = "0x7D18E4", Length = "0x84")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "SmoothSlope", MemberParameters = new object[]
				{
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Biomes.MarbleBiome.SlabState", Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new object[]
				{
					typeof(Delegate),
					typeof(Delegate)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004F65 RID: 20325 RVA: 0x00030053 File Offset: 0x0002E253
			[global::Cpp2ILInjected.Token(Token = "0x6004640")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27D8", Offset = "0x7D27D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private Slab(MarbleBiome.SlabState state, bool hasWall)
			{
				throw null;
			}

			// Token: 0x06004F66 RID: 20326 RVA: 0x00030056 File Offset: 0x0002E256
			[global::Cpp2ILInjected.Token(Token = "0x6004641")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D1A2C", Offset = "0x7D1A2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public MarbleBiome.Slab WithState(MarbleBiome.SlabState state)
			{
				throw null;
			}

			// Token: 0x06004F67 RID: 20327 RVA: 0x00030059 File Offset: 0x0002E259
			[global::Cpp2ILInjected.Token(Token = "0x6004642")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D2688", Offset = "0x7D2688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static MarbleBiome.Slab Create(MarbleBiome.SlabState state, bool hasWall)
			{
				throw null;
			}

			// Token: 0x04008D16 RID: 36118
			[global::Cpp2ILInjected.Token(Token = "0x4008265")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly MarbleBiome.SlabState State;

			// Token: 0x04008D17 RID: 36119
			[global::Cpp2ILInjected.Token(Token = "0x4008266")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly bool HasWall;
		}
	}
}
