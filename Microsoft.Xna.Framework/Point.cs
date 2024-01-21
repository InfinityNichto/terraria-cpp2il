using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200026E")]
public struct Point : IEquatable<Point>
{
	[Cpp2IlInjected.Token(Token = "0x4001C93")]
	private static Point zeroPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C94")]
	public int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C95")]
	public int Y;

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public static Point Zero
	{
		[Cpp2IlInjected.Token(Token = "0x60011FE")]
		[Cpp2IlInjected.Address(RVA = "0x1583DE0", Offset = "0x1583DE0", VA = "0x1583DE0")]
		get
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60011FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A2888", Offset = "0x3A2888", VA = "0x3A2888")]
	public Point(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001200")]
	[Cpp2IlInjected.Address(RVA = "0x1583E68", Offset = "0x1583E68", VA = "0x1583E68")]
	public static bool operator ==(Point a, Point b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001201")]
	[Cpp2IlInjected.Address(RVA = "0x1583EA4", Offset = "0x1583EA4", VA = "0x1583EA4")]
	public static bool operator !=(Point a, Point b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001202")]
	[Cpp2IlInjected.Address(RVA = "0x3A2894", Offset = "0x3A2894", VA = "0x3A2894", Slot = "4")]
	public bool Equals(Point other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001203")]
	[Cpp2IlInjected.Address(RVA = "0x3A28B8", Offset = "0x3A28B8", VA = "0x3A28B8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001204")]
	[Cpp2IlInjected.Address(RVA = "0x3A28C0", Offset = "0x3A28C0", VA = "0x3A28C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001205")]
	[Cpp2IlInjected.Address(RVA = "0x3A28D0", Offset = "0x3A28D0", VA = "0x3A28D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
