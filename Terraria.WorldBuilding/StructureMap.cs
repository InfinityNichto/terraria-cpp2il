using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036C")]
public class StructureMap
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003172")]
	private readonly List<Rectangle> _structures;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003173")]
	private readonly List<Rectangle> _protectedStructures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003174")]
	private readonly object _lock;

	[Cpp2IlInjected.Token(Token = "0x6002C9D")]
	[Cpp2IlInjected.Address(RVA = "0xA0EA58", Offset = "0xA0EA58", VA = "0xA0EA58")]
	public bool CanPlace(Rectangle area, int padding = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C9E")]
	[Cpp2IlInjected.Address(RVA = "0xA0EC34", Offset = "0xA0EC34", VA = "0xA0EC34")]
	public bool CanPlace(Rectangle area, bool[] validTiles, int padding = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C9F")]
	[Cpp2IlInjected.Address(RVA = "0xA0EFA4", Offset = "0xA0EFA4", VA = "0xA0EFA4")]
	public Rectangle GetBoundingBox()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA0")]
	[Cpp2IlInjected.Address(RVA = "0xA0F4FC", Offset = "0xA0F4FC", VA = "0xA0F4FC")]
	public void AddStructure(Rectangle area, int padding = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA1")]
	[Cpp2IlInjected.Address(RVA = "0xA0EB0C", Offset = "0xA0EB0C", VA = "0xA0EB0C")]
	public void AddProtectedStructure(Rectangle area, int padding = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA2")]
	[Cpp2IlInjected.Address(RVA = "0xA0F604", Offset = "0xA0F604", VA = "0xA0F604")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CA3")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6D0", Offset = "0xA0F6D0", VA = "0xA0F6D0")]
	public StructureMap()
	{
	}
}
