using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000440")]
public class NPCDebuffImmunityData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400630F")]
	public bool ImmuneToWhips;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4006310")]
	public bool ImmuneToAllBuffsThatAreNotWhips;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006311")]
	public int[] SpecificallyImmuneTo;

	[Cpp2IlInjected.Token(Token = "0x6003156")]
	[Cpp2IlInjected.Address(RVA = "0x101475C", Offset = "0x101475C", VA = "0x101475C")]
	public void ApplyToNPC(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003157")]
	[Cpp2IlInjected.Address(RVA = "0x1014888", Offset = "0x1014888", VA = "0x1014888")]
	public NPCDebuffImmunityData()
	{
	}
}
