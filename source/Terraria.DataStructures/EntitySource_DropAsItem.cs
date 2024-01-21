using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000467")]
public class EntitySource_DropAsItem : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400641A")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x600321D")]
	[Cpp2IlInjected.Address(RVA = "0x1013784", Offset = "0x1013784", VA = "0x1013784")]
	public EntitySource_DropAsItem(Entity entity)
	{
	}
}
