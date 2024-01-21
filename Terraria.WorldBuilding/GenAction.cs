using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000357")]
public abstract class GenAction : GenBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030BE")]
	public GenAction NextAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40030BF")]
	public ShapeData OutputData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40030C0")]
	private bool _returnFalseOnFailure;

	[Cpp2IlInjected.Token(Token = "0x6002C59")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool Apply(Point origin, int x, int y, params object[] args);

	[Cpp2IlInjected.Token(Token = "0x6002C5A")]
	[Cpp2IlInjected.Address(RVA = "0x12FDC0C", Offset = "0x12FDC0C", VA = "0x12FDC0C")]
	protected bool UnitApply(Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C5B")]
	[Cpp2IlInjected.Address(RVA = "0x13003A4", Offset = "0x13003A4", VA = "0x13003A4")]
	public GenAction IgnoreFailures()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C5C")]
	[Cpp2IlInjected.Address(RVA = "0x12FF6C0", Offset = "0x12FF6C0", VA = "0x12FF6C0")]
	protected bool Fail()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C5D")]
	[Cpp2IlInjected.Address(RVA = "0x13003B0", Offset = "0x13003B0", VA = "0x13003B0")]
	public GenAction Output(ShapeData data)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C5E")]
	[Cpp2IlInjected.Address(RVA = "0x12FDC98", Offset = "0x12FDC98", VA = "0x12FDC98")]
	protected GenAction()
	{
	}
}
