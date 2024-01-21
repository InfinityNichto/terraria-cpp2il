using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000455")]
public class EntitySource_ItemUse : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400640C")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400640D")]
	public readonly Item Item;

	[Cpp2IlInjected.Token(Token = "0x600320B")]
	[Cpp2IlInjected.Address(RVA = "0x1013814", Offset = "0x1013814", VA = "0x1013814")]
	public EntitySource_ItemUse(Entity entity, Item item)
	{
	}
}
