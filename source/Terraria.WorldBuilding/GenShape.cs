using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000364")]
public abstract class GenShape : GenBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030CD")]
	private ShapeData _outputData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40030CE")]
	protected bool _quitOnFail;

	[Cpp2IlInjected.Token(Token = "0x6002C78")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool Perform(Point origin, GenAction action);

	[Cpp2IlInjected.Token(Token = "0x6002C79")]
	[Cpp2IlInjected.Address(RVA = "0x13009B0", Offset = "0x13009B0", VA = "0x13009B0")]
	protected bool UnitApply(GenAction action, Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C7A")]
	[Cpp2IlInjected.Address(RVA = "0x1300A1C", Offset = "0x1300A1C", VA = "0x1300A1C")]
	public GenShape Output(ShapeData outputData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C7B")]
	[Cpp2IlInjected.Address(RVA = "0x1300A24", Offset = "0x1300A24", VA = "0x1300A24")]
	public GenShape QuitOnFail(bool value = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C7C")]
	[Cpp2IlInjected.Address(RVA = "0x130083C", Offset = "0x130083C", VA = "0x130083C")]
	protected GenShape()
	{
	}
}
