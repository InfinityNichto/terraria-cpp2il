using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000363")]
public struct GenShapeActionPair
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40030CB")]
	public readonly GenShape Shape;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40030CC")]
	public readonly GenAction Action;

	[Cpp2IlInjected.Token(Token = "0x6002C77")]
	[Cpp2IlInjected.Address(RVA = "0x39E348", Offset = "0x39E348", VA = "0x39E348")]
	public GenShapeActionPair(GenShape shape, GenAction action)
	{
	}
}
