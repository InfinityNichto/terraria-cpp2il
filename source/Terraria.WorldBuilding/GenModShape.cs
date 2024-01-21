using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035C")]
public abstract class GenModShape : GenShape
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40030C5")]
	protected ShapeData _data;

	[Cpp2IlInjected.Token(Token = "0x6002C6C")]
	[Cpp2IlInjected.Address(RVA = "0x130081C", Offset = "0x130081C", VA = "0x130081C")]
	public GenModShape(ShapeData data)
	{
	}
}
