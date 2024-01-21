using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FE")]
public class MarbleBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x20009FA")]
	private delegate bool SlabState(int x, int y, int scale);

	[Cpp2IlInjected.Token(Token = "0x20009FB")]
	private static class SlabStates
	{
		[Cpp2IlInjected.Token(Token = "0x6004F94")]
		[Cpp2IlInjected.Address(RVA = "0x107A288", Offset = "0x107A288", VA = "0x107A288")]
		public static bool Empty(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F95")]
		[Cpp2IlInjected.Address(RVA = "0x107A290", Offset = "0x107A290", VA = "0x107A290")]
		public static bool Solid(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F96")]
		[Cpp2IlInjected.Address(RVA = "0x107A298", Offset = "0x107A298", VA = "0x107A298")]
		public static bool HalfBrick(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F97")]
		[Cpp2IlInjected.Address(RVA = "0x107A2AC", Offset = "0x107A2AC", VA = "0x107A2AC")]
		public static bool BottomRightFilled(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F98")]
		[Cpp2IlInjected.Address(RVA = "0x107A2C4", Offset = "0x107A2C4", VA = "0x107A2C4")]
		public static bool BottomLeftFilled(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F99")]
		[Cpp2IlInjected.Address(RVA = "0x107A2D8", Offset = "0x107A2D8", VA = "0x107A2D8")]
		public static bool TopRightFilled(int x, int y, int scale)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9A")]
		[Cpp2IlInjected.Address(RVA = "0x107A2EC", Offset = "0x107A2EC", VA = "0x107A2EC")]
		public static bool TopLeftFilled(int x, int y, int scale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009FC")]
	private struct Slab
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D03")]
		public readonly SlabState State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008D04")]
		public readonly bool HasWall;

		[Cpp2IlInjected.Token(Token = "0x170008CE")]
		public bool IsSolid
		{
			[Cpp2IlInjected.Token(Token = "0x6004F9B")]
			[Cpp2IlInjected.Address(RVA = "0x39BA88", Offset = "0x39BA88", VA = "0x39BA88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9C")]
		[Cpp2IlInjected.Address(RVA = "0x39BA90", Offset = "0x39BA90", VA = "0x39BA90")]
		private Slab(SlabState state, bool hasWall)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9D")]
		[Cpp2IlInjected.Address(RVA = "0x39BA9C", Offset = "0x39BA9C", VA = "0x39BA9C")]
		public Slab WithState(SlabState state)
		{
			return default(Slab);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F9E")]
		[Cpp2IlInjected.Address(RVA = "0x107A184", Offset = "0x107A184", VA = "0x107A184")]
		public static Slab Create(SlabState state, bool hasWall)
		{
			return default(Slab);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006C01")]
	private const int SCALE = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C02")]
	private Slab[,] _slabs;

	[Cpp2IlInjected.Token(Token = "0x6003DE4")]
	[Cpp2IlInjected.Address(RVA = "0x1078CEC", Offset = "0x1078CEC", VA = "0x1078CEC")]
	private void SmoothSlope(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE5")]
	[Cpp2IlInjected.Address(RVA = "0x1079014", Offset = "0x1079014", VA = "0x1079014")]
	private void PlaceSlab(Slab slab, int originX, int originY, int scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE6")]
	[Cpp2IlInjected.Address(RVA = "0x1079840", Offset = "0x1079840", VA = "0x1079840")]
	private static bool IsGroupSolid(int x, int y, int scale)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE7")]
	[Cpp2IlInjected.Address(RVA = "0x1079928", Offset = "0x1079928", VA = "0x1079928", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE8")]
	[Cpp2IlInjected.Address(RVA = "0x107A194", Offset = "0x107A194", VA = "0x107A194")]
	public MarbleBiome()
	{
	}
}
