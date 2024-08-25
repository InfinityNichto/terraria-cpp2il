using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	[global::Cpp2ILInjected.Token(Token = "0x20008F4")]
	public class MarbleBiome : MicroBiome
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6004633")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D2690", Offset = "0x7D2690", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MicroBiome), Member = ".ctor", ReturnType = typeof(void))]
		public MarbleBiome()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008263")]
		private const int SCALE = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4008264")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MarbleBiome.Slab[,] _slabs;

		[global::Cpp2ILInjected.Token(Token = "0x20008F5")]
		private delegate bool SlabState(int x, int y, int scale);

		[global::Cpp2ILInjected.Token(Token = "0x20008F6")]
		private static class SlabStates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004638")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D277C", Offset = "0x7D277C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool Empty(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004639")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D2784", Offset = "0x7D2784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool Solid(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600463A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D278C", Offset = "0x7D278C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool HalfBrick(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600463B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27A0", Offset = "0x7D27A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool BottomRightFilled(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600463C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27B0", Offset = "0x7D27B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool BottomLeftFilled(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600463D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27BC", Offset = "0x7D27BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool TopRightFilled(int x, int y, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600463E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27C8", Offset = "0x7D27C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool TopLeftFilled(int x, int y, int scale)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008F7")]
		private struct Slab
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004640")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D27D8", Offset = "0x7D27D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private Slab(MarbleBiome.SlabState state, bool hasWall)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004641")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D1A2C", Offset = "0x7D1A2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public MarbleBiome.Slab WithState(MarbleBiome.SlabState state)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004642")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D2688", Offset = "0x7D2688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static MarbleBiome.Slab Create(MarbleBiome.SlabState state, bool hasWall)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008265")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly MarbleBiome.SlabState State;

			[global::Cpp2ILInjected.Token(Token = "0x4008266")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly bool HasWall;
		}
	}
}
