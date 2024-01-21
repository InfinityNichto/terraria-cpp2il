using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000450")]
public struct Point16
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40063FF")]
	public readonly short X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4006400")]
	public readonly short Y;

	[Cpp2IlInjected.Token(Token = "0x4006401")]
	public static Point16 Zero;

	[Cpp2IlInjected.Token(Token = "0x4006402")]
	public static Point16 NegativeOne;

	[Cpp2IlInjected.Token(Token = "0x60031FB")]
	[Cpp2IlInjected.Address(RVA = "0x39D978", Offset = "0x39D978", VA = "0x39D978")]
	public Point16(Point point)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031FC")]
	[Cpp2IlInjected.Address(RVA = "0x39D984", Offset = "0x39D984", VA = "0x39D984")]
	public Point16(int X, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031FD")]
	[Cpp2IlInjected.Address(RVA = "0x39D990", Offset = "0x39D990", VA = "0x39D990")]
	public Point16(short X, short Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031FE")]
	[Cpp2IlInjected.Address(RVA = "0x122E25C", Offset = "0x122E25C", VA = "0x122E25C")]
	public static Point16 Max(int firstX, int firstY, int secondX, int secondY)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x60031FF")]
	[Cpp2IlInjected.Address(RVA = "0x39D99C", Offset = "0x39D99C", VA = "0x39D99C")]
	public Point16 Max(int compareX, int compareY)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x6003200")]
	[Cpp2IlInjected.Address(RVA = "0x39D9BC", Offset = "0x39D9BC", VA = "0x39D9BC")]
	public Point16 Max(Point16 compareTo)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x6003201")]
	[Cpp2IlInjected.Address(RVA = "0x122E2B8", Offset = "0x122E2B8", VA = "0x122E2B8")]
	public static bool operator ==(Point16 first, Point16 second)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003202")]
	[Cpp2IlInjected.Address(RVA = "0x122E2E0", Offset = "0x122E2E0", VA = "0x122E2E0")]
	public static bool operator !=(Point16 first, Point16 second)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003203")]
	[Cpp2IlInjected.Address(RVA = "0x39D9E0", Offset = "0x39D9E0", VA = "0x39D9E0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003204")]
	[Cpp2IlInjected.Address(RVA = "0x39D9E8", Offset = "0x39D9E8", VA = "0x39D9E8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003205")]
	[Cpp2IlInjected.Address(RVA = "0x39D9F8", Offset = "0x39D9F8", VA = "0x39D9F8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
