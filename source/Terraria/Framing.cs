using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000330")]
public class Framing
{
	[Cpp2IlInjected.Token(Token = "0x2000855")]
	private struct BlockStyle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007EC4")]
		public bool top;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007EC5")]
		public bool bottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4007EC6")]
		public bool left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4007EC7")]
		public bool right;

		[Cpp2IlInjected.Token(Token = "0x6004A16")]
		[Cpp2IlInjected.Address(RVA = "0x39E53C", Offset = "0x39E53C", VA = "0x39E53C")]
		public BlockStyle(bool up, bool down, bool left, bool right)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004A17")]
		[Cpp2IlInjected.Address(RVA = "0x39E554", Offset = "0x39E554", VA = "0x39E554")]
		public void Clear()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002CEF")]
	private static Point16[][] selfFrame8WayLookup;

	[Cpp2IlInjected.Token(Token = "0x4002CF0")]
	private static Point16[][] wallFrameLookup;

	[Cpp2IlInjected.Token(Token = "0x4002CF1")]
	private static Point16 frameSize8Way;

	[Cpp2IlInjected.Token(Token = "0x4002CF2")]
	private static Point16 wallFrameSize;

	[Cpp2IlInjected.Token(Token = "0x4002CF3")]
	private static BlockStyle[] blockStyleLookup;

	[Cpp2IlInjected.Token(Token = "0x4002CF4")]
	private static int[][] phlebasTileFrameNumberLookup;

	[Cpp2IlInjected.Token(Token = "0x4002CF5")]
	private static int[][] lazureTileFrameNumberLookup;

	[Cpp2IlInjected.Token(Token = "0x4002CF6")]
	private static int[][] centerWallFrameLookup;

	[Cpp2IlInjected.Token(Token = "0x6002636")]
	[Cpp2IlInjected.Address(RVA = "0x132ED3C", Offset = "0x132ED3C", VA = "0x132ED3C")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002637")]
	[Cpp2IlInjected.Address(RVA = "0x132FDD4", Offset = "0x132FDD4", VA = "0x132FDD4")]
	private static BlockStyle FindBlockStyle(Tile blockTile)
	{
		return default(BlockStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002638")]
	[Cpp2IlInjected.Address(RVA = "0x132F974", Offset = "0x132F974", VA = "0x132F974")]
	public static void Add8WayLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002639")]
	[Cpp2IlInjected.Address(RVA = "0x132FAD4", Offset = "0x132FAD4", VA = "0x132FAD4")]
	public static void Add8WayLookup(int lookup, short x, short y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600263A")]
	[Cpp2IlInjected.Address(RVA = "0x132FC3C", Offset = "0x132FC3C", VA = "0x132FC3C")]
	public static void AddWallFrameLookup(int lookup, short point1X, short point1Y, short point2X, short point2Y, short point3X, short point3Y, short point4X, short point4Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600263B")]
	[Cpp2IlInjected.Address(RVA = "0x132FE4C", Offset = "0x132FE4C", VA = "0x132FE4C")]
	private static bool WillItBlend(ushort myType, ushort otherType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600263C")]
	[Cpp2IlInjected.Address(RVA = "0x132FFB8", Offset = "0x132FFB8", VA = "0x132FFB8")]
	public static void SelfFrame8Way(int i, int j, Tile centerTile, bool resetFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600263D")]
	[Cpp2IlInjected.Address(RVA = "0x1330670", Offset = "0x1330670", VA = "0x1330670")]
	public static void WallFrame(int i, int j, bool resetFrame = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600263E")]
	[Cpp2IlInjected.Address(RVA = "0x132B008", Offset = "0x132B008", VA = "0x132B008")]
	public static Tile GetTileSafely(Vector2 position)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x600263F")]
	[Cpp2IlInjected.Address(RVA = "0x1330F1C", Offset = "0x1330F1C", VA = "0x1330F1C")]
	public static Tile GetTileSafely(Point pt)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002640")]
	[Cpp2IlInjected.Address(RVA = "0x1330F20", Offset = "0x1330F20", VA = "0x1330F20")]
	public static Tile GetTileSafely(Point16 pt)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002641")]
	[Cpp2IlInjected.Address(RVA = "0x1330550", Offset = "0x1330550", VA = "0x1330550")]
	public static Tile GetTileSafely(int i, int j)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002642")]
	[Cpp2IlInjected.Address(RVA = "0x1330F30", Offset = "0x1330F30", VA = "0x1330F30")]
	public Framing()
	{
	}
}
