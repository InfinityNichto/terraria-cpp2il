using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035A")]
public abstract class GenCondition : GenBase
{
	[Cpp2IlInjected.Token(Token = "0x200089A")]
	private enum AreaType
	{
		[Cpp2IlInjected.Token(Token = "0x400806A")]
		And,
		[Cpp2IlInjected.Token(Token = "0x400806B")]
		Or,
		[Cpp2IlInjected.Token(Token = "0x400806C")]
		None
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030C1")]
	private bool InvertResults;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40030C2")]
	private int _width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40030C3")]
	private int _height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40030C4")]
	private AreaType _areaType;

	[Cpp2IlInjected.Token(Token = "0x6002C66")]
	[Cpp2IlInjected.Address(RVA = "0x130067C", Offset = "0x130067C", VA = "0x130067C")]
	public bool IsValid(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C67")]
	[Cpp2IlInjected.Address(RVA = "0x13007EC", Offset = "0x13007EC", VA = "0x13007EC")]
	public GenCondition Not()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C68")]
	[Cpp2IlInjected.Address(RVA = "0x13007FC", Offset = "0x13007FC", VA = "0x13007FC")]
	public GenCondition AreaOr(int width, int height)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C69")]
	[Cpp2IlInjected.Address(RVA = "0x130080C", Offset = "0x130080C", VA = "0x130080C")]
	public GenCondition AreaAnd(int width, int height)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C6A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CheckValidity(int x, int y);

	[Cpp2IlInjected.Token(Token = "0x6002C6B")]
	[Cpp2IlInjected.Address(RVA = "0x12FFB00", Offset = "0x12FFB00", VA = "0x12FFB00")]
	protected GenCondition()
	{
	}
}
