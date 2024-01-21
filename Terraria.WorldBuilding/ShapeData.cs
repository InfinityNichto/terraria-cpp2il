using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036A")]
public class ShapeData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400316B")]
	private HashSet<Point16> _points;

	[Cpp2IlInjected.Token(Token = "0x1700059D")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6002C8A")]
		[Cpp2IlInjected.Address(RVA = "0x1304B78", Offset = "0x1304B78", VA = "0x1304B78")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C8B")]
	[Cpp2IlInjected.Address(RVA = "0x1304BC4", Offset = "0x1304BC4", VA = "0x1304BC4")]
	public ShapeData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C8C")]
	[Cpp2IlInjected.Address(RVA = "0x1304C48", Offset = "0x1304C48", VA = "0x1304C48")]
	public ShapeData(ShapeData original)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C8D")]
	[Cpp2IlInjected.Address(RVA = "0x1300314", Offset = "0x1300314", VA = "0x1300314")]
	public void Add(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C8E")]
	[Cpp2IlInjected.Address(RVA = "0x1304CD8", Offset = "0x1304CD8", VA = "0x1304CD8")]
	public void Remove(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C8F")]
	[Cpp2IlInjected.Address(RVA = "0x1304D68", Offset = "0x1304D68", VA = "0x1304D68")]
	public HashSet<Point16> GetData()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C90")]
	[Cpp2IlInjected.Address(RVA = "0x1304D70", Offset = "0x1304D70", VA = "0x1304D70")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C91")]
	[Cpp2IlInjected.Address(RVA = "0x130187C", Offset = "0x130187C", VA = "0x130187C")]
	public bool Contains(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C92")]
	[Cpp2IlInjected.Address(RVA = "0x1304DCC", Offset = "0x1304DCC", VA = "0x1304DCC")]
	public void Add(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C93")]
	[Cpp2IlInjected.Address(RVA = "0x1304F04", Offset = "0x1304F04", VA = "0x1304F04")]
	public void Subtract(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C94")]
	[Cpp2IlInjected.Address(RVA = "0x130503C", Offset = "0x130503C", VA = "0x130503C")]
	public static Rectangle GetBounds(Point origin, params ShapeData[] shapes)
	{
		return default(Rectangle);
	}
}
