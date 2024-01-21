using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000466")]
public class EntitySource_BossSpawn : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006419")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x600321C")]
	[Cpp2IlInjected.Address(RVA = "0x10136E4", Offset = "0x10136E4", VA = "0x10136E4")]
	public EntitySource_BossSpawn(Entity entity)
	{
	}
}
