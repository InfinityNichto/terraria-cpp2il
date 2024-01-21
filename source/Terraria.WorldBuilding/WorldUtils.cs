using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000371")]
public static class WorldUtils
{
	[Cpp2IlInjected.Token(Token = "0x6002CBD")]
	[Cpp2IlInjected.Address(RVA = "0xA1225C", Offset = "0xA1225C", VA = "0xA1225C")]
	public static Rectangle ClampToWorld(Rectangle tileRectangle)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CBE")]
	[Cpp2IlInjected.Address(RVA = "0xA1240C", Offset = "0xA1240C", VA = "0xA1240C")]
	public static bool Gen(Point origin, GenShape shape, GenAction action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CBF")]
	[Cpp2IlInjected.Address(RVA = "0xA12444", Offset = "0xA12444", VA = "0xA12444")]
	public static bool Gen(Point origin, GenShapeActionPair pair)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC0")]
	[Cpp2IlInjected.Address(RVA = "0xA1247C", Offset = "0xA1247C", VA = "0xA1247C")]
	public static bool Find(Point origin, GenSearch search, out Point result)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC1")]
	[Cpp2IlInjected.Address(RVA = "0xA1258C", Offset = "0xA1258C", VA = "0xA1258C")]
	public static void ClearTile(int x, int y, bool frameNeighbors = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC2")]
	[Cpp2IlInjected.Address(RVA = "0xA126C4", Offset = "0xA126C4", VA = "0xA126C4")]
	public static void ClearWall(int x, int y, bool frameNeighbors = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC3")]
	[Cpp2IlInjected.Address(RVA = "0xA128CC", Offset = "0xA128CC", VA = "0xA128CC")]
	public static void TileFrame(int x, int y, bool frameNeighbors = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC4")]
	[Cpp2IlInjected.Address(RVA = "0xA129D8", Offset = "0xA129D8", VA = "0xA129D8")]
	public static void ClearChestLocation(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC5")]
	[Cpp2IlInjected.Address(RVA = "0xA12A2C", Offset = "0xA12A2C", VA = "0xA12A2C")]
	public static void WireLine(Point start, Point end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC6")]
	[Cpp2IlInjected.Address(RVA = "0xA12D3C", Offset = "0xA12D3C", VA = "0xA12D3C")]
	public static void DebugRegen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CC7")]
	[Cpp2IlInjected.Address(RVA = "0xA1ACCC", Offset = "0xA1ACCC", VA = "0xA1ACCC")]
	public static void DebugRotate()
	{
	}
}
