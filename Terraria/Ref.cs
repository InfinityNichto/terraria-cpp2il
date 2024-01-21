using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000345")]
public class Ref<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002F16")]
	public T Value;

	[Cpp2IlInjected.Token(Token = "0x6002759")]
	[Cpp2IlInjected.Address(RVA = "0x164558C", Offset = "0x164558C", VA = "0x164558C")]
	public Ref()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600275A")]
	[Cpp2IlInjected.Address(RVA = "0x1645594", Offset = "0x1645594", VA = "0x1645594")]
	public Ref(T value)
	{
	}
}
