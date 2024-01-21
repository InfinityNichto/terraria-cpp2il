using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200046C")]
public class EntitySource_OnHit_ByProjectileSourceID : AEntitySource_OnHit
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006420")]
	public readonly int SourceId;

	[Cpp2IlInjected.Token(Token = "0x6003222")]
	[Cpp2IlInjected.Address(RVA = "0x10138EC", Offset = "0x10138EC", VA = "0x10138EC")]
	public EntitySource_OnHit_ByProjectileSourceID(Entity entityStriking, Entity entityStruck, int projectileSourceId)
	{
	}
}
