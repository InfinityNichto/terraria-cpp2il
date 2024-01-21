using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200046A")]
public class EntitySource_Loot : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400641D")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x6003220")]
	[Cpp2IlInjected.Address(RVA = "0x101386C", Offset = "0x101386C", VA = "0x101386C")]
	public EntitySource_Loot(Entity entity)
	{
	}
}
