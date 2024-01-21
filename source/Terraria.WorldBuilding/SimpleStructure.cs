using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200036B")]
public class SimpleStructure : GenStructure
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400316C")]
	private int[,] _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400316D")]
	private int _width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400316E")]
	private int _height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400316F")]
	private GenAction[] _actions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003170")]
	private bool _xMirror;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4003171")]
	private bool _yMirror;

	[Cpp2IlInjected.Token(Token = "0x1700059E")]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x6002C95")]
		[Cpp2IlInjected.Address(RVA = "0xA0E5D4", Offset = "0xA0E5D4", VA = "0xA0E5D4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700059F")]
	public int Height
	{
		[Cpp2IlInjected.Token(Token = "0x6002C96")]
		[Cpp2IlInjected.Address(RVA = "0xA0E5DC", Offset = "0xA0E5DC", VA = "0xA0E5DC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C97")]
	[Cpp2IlInjected.Address(RVA = "0xA0E5E4", Offset = "0xA0E5E4", VA = "0xA0E5E4")]
	public SimpleStructure(params string[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C98")]
	[Cpp2IlInjected.Address(RVA = "0xA0E714", Offset = "0xA0E714", VA = "0xA0E714")]
	public SimpleStructure(string data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C99")]
	[Cpp2IlInjected.Address(RVA = "0xA0E60C", Offset = "0xA0E60C", VA = "0xA0E60C")]
	private void ReadData(string[] lines)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C9A")]
	[Cpp2IlInjected.Address(RVA = "0xA0E7A4", Offset = "0xA0E7A4", VA = "0xA0E7A4")]
	public SimpleStructure SetActions(params GenAction[] actions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C9B")]
	[Cpp2IlInjected.Address(RVA = "0xA0E7AC", Offset = "0xA0E7AC", VA = "0xA0E7AC")]
	public SimpleStructure Mirror(bool horizontalMirror, bool verticalMirror)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C9C")]
	[Cpp2IlInjected.Address(RVA = "0xA0E7B8", Offset = "0xA0E7B8", VA = "0xA0E7B8", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}
}
