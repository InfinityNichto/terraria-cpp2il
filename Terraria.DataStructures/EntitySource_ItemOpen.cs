using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000456")]
public class EntitySource_ItemOpen : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400640E")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400640F")]
	public readonly int ItemType;

	[Cpp2IlInjected.Token(Token = "0x600320C")]
	[Cpp2IlInjected.Address(RVA = "0x10137EC", Offset = "0x10137EC", VA = "0x10137EC")]
	public EntitySource_ItemOpen(Entity entity, int itemType)
	{
	}
}
