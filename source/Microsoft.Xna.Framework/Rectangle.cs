using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000270")]
public struct Rectangle
{
	[Cpp2IlInjected.Token(Token = "0x4001C9B")]
	private static Rectangle emptyRectangle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C9C")]
	public int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C9D")]
	public int Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001C9E")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001C9F")]
	public int Height;

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public Point Center
	{
		[Cpp2IlInjected.Token(Token = "0x600123B")]
		[Cpp2IlInjected.Address(RVA = "0x3A29DC", Offset = "0x3A29DC", VA = "0x3A29DC")]
		get
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public Point Location
	{
		[Cpp2IlInjected.Token(Token = "0x600123C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A08", Offset = "0x3A2A08", VA = "0x3A2A08")]
		get
		{
			return default(Point);
		}
		[Cpp2IlInjected.Token(Token = "0x600123D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A1C", Offset = "0x3A2A1C", VA = "0x3A2A1C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public bool IsEmpty
	{
		[Cpp2IlInjected.Token(Token = "0x600123E")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A28", Offset = "0x3A2A28", VA = "0x3A2A28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public static Rectangle Empty
	{
		[Cpp2IlInjected.Token(Token = "0x600123F")]
		[Cpp2IlInjected.Address(RVA = "0x158626C", Offset = "0x158626C", VA = "0x158626C")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public int Left
	{
		[Cpp2IlInjected.Token(Token = "0x6001240")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A60", Offset = "0x3A2A60", VA = "0x3A2A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public int Right
	{
		[Cpp2IlInjected.Token(Token = "0x6001241")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A68", Offset = "0x3A2A68", VA = "0x3A2A68")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public int Top
	{
		[Cpp2IlInjected.Token(Token = "0x6001242")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A78", Offset = "0x3A2A78", VA = "0x3A2A78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public int Bottom
	{
		[Cpp2IlInjected.Token(Token = "0x6001243")]
		[Cpp2IlInjected.Address(RVA = "0x3A2A80", Offset = "0x3A2A80", VA = "0x3A2A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001244")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A90", Offset = "0x3A2A90", VA = "0x3A2A90")]
	public Rectangle(int x, int y, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001245")]
	[Cpp2IlInjected.Address(RVA = "0x1586328", Offset = "0x1586328", VA = "0x1586328")]
	public static Rectangle Union(Rectangle value1, Rectangle value2)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001246")]
	[Cpp2IlInjected.Address(RVA = "0x1586420", Offset = "0x1586420", VA = "0x1586420")]
	public static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001247")]
	[Cpp2IlInjected.Address(RVA = "0x1586520", Offset = "0x1586520", VA = "0x1586520")]
	public static Rectangle Intersect(Rectangle value1, Rectangle value2)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001248")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AA0", Offset = "0x3A2AA0", VA = "0x3A2AA0")]
	public void Intersects(ref Rectangle value, out bool result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001249")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AA8", Offset = "0x3A2AA8", VA = "0x3A2AA8")]
	public bool Contains(Point value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600124A")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AF8", Offset = "0x3A2AF8", VA = "0x3A2AF8")]
	public bool Contains(Rectangle value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600124B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B1C", Offset = "0x3A2B1C", VA = "0x3A2B1C")]
	public void Contains(ref Rectangle value, out bool result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600124C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B24", Offset = "0x3A2B24", VA = "0x3A2B24")]
	public bool Contains(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600124D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2B74", Offset = "0x3A2B74", VA = "0x3A2B74")]
	public void Contains(ref Point value, out bool result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600124E")]
	[Cpp2IlInjected.Address(RVA = "0x15865E0", Offset = "0x15865E0", VA = "0x15865E0")]
	public static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600124F")]
	[Cpp2IlInjected.Address(RVA = "0x15869A8", Offset = "0x15869A8", VA = "0x15869A8")]
	public static bool operator ==(Rectangle a, Rectangle b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001250")]
	[Cpp2IlInjected.Address(RVA = "0x15869E4", Offset = "0x15869E4", VA = "0x15869E4")]
	public static bool operator !=(Rectangle a, Rectangle b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001251")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BCC", Offset = "0x3A2BCC", VA = "0x3A2BCC")]
	public void Offset(Point offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001252")]
	[Cpp2IlInjected.Address(RVA = "0x3A2BE8", Offset = "0x3A2BE8", VA = "0x3A2BE8")]
	public void Offset(int offsetX, int offsetY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001253")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C04", Offset = "0x3A2C04", VA = "0x3A2C04")]
	public void Inflate(int horizontalValue, int verticalValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001254")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C3C", Offset = "0x3A2C3C", VA = "0x3A2C3C")]
	public bool Intersects(Rectangle rect)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001255")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C60", Offset = "0x3A2C60", VA = "0x3A2C60")]
	public bool Equals(Rectangle other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001256")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C84", Offset = "0x3A2C84", VA = "0x3A2C84", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001257")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C8C", Offset = "0x3A2C8C", VA = "0x3A2C8C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001258")]
	[Cpp2IlInjected.Address(RVA = "0x3A2C94", Offset = "0x3A2C94", VA = "0x3A2C94", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
