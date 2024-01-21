using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005CE")]
public static class CommonCode
{
	[Cpp2IlInjected.Token(Token = "0x6003CB3")]
	[Cpp2IlInjected.Address(RVA = "0xE71AB8", Offset = "0xE71AB8", VA = "0xE71AB8")]
	public static void DropItemFromNPC(NPC npc, int itemId, int stack, bool scattered = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CB4")]
	[Cpp2IlInjected.Address(RVA = "0xE71F64", Offset = "0xE71F64", VA = "0xE71F64")]
	public static void DropItemLocalPerClientAndSetNPCMoneyTo0(NPC npc, int itemId, int stack, bool interactionRequired = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CB5")]
	[Cpp2IlInjected.Address(RVA = "0xE726DC", Offset = "0xE726DC", VA = "0xE726DC")]
	public static void DropItemForEachInteractingPlayerOnThePlayer(NPC npc, int itemId, UnifiedRandom rng, int chanceNumerator, int chanceDenominator, int stack = 1, bool interactionRequired = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CB6")]
	[Cpp2IlInjected.Address(RVA = "0xE71C90", Offset = "0xE71C90", VA = "0xE71C90")]
	public static void ModifyItemDropFromNPC(NPC npc, int itemIndex)
	{
	}
}
