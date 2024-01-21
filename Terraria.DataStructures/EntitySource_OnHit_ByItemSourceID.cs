using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200046D")]
public class EntitySource_OnHit_ByItemSourceID : AEntitySource_OnHit
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006421")]
	public readonly int SourceId;

	[Cpp2IlInjected.Token(Token = "0x6003223")]
	[Cpp2IlInjected.Address(RVA = "0x10138BC", Offset = "0x10138BC", VA = "0x10138BC")]
	public EntitySource_OnHit_ByItemSourceID(Entity entityStriking, Entity entityStruck, int itemSourceId)
	{
	}
}
