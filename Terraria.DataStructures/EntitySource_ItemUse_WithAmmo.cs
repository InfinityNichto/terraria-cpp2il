using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000457")]
public class EntitySource_ItemUse_WithAmmo : EntitySource_ItemUse
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006410")]
	public readonly int AmmoItemIdUsed;

	[Cpp2IlInjected.Token(Token = "0x600320D")]
	[Cpp2IlInjected.Address(RVA = "0x101383C", Offset = "0x101383C", VA = "0x101383C")]
	public EntitySource_ItemUse_WithAmmo(Entity entity, Item item, int ammoItemIdUsed)
	{
	}
}
