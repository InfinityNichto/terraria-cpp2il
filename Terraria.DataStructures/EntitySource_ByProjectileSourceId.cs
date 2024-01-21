using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200045F")]
public class EntitySource_ByProjectileSourceId : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006416")]
	public readonly int SourceId;

	[Cpp2IlInjected.Token(Token = "0x6003215")]
	[Cpp2IlInjected.Address(RVA = "0x101375C", Offset = "0x101375C", VA = "0x101375C")]
	public EntitySource_ByProjectileSourceId(int projectileSourceId)
	{
	}
}
