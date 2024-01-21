using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000658")]
public class NPCKilledCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x4006CB5")]
	private const string Identifier = "NPC_KILLED";

	[Cpp2IlInjected.Token(Token = "0x4006CB6")]
	private static Dictionary<short, List<NPCKilledCondition>> _listeners;

	[Cpp2IlInjected.Token(Token = "0x4006CB7")]
	private static bool _isListenerHooked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CB8")]
	private readonly LocalUser _user;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CB9")]
	private short[] _npcIds;

	[Cpp2IlInjected.Token(Token = "0x6003FAA")]
	[Cpp2IlInjected.Address(RVA = "0xFAB69C", Offset = "0xFAB69C", VA = "0xFAB69C")]
	private NPCKilledCondition(LocalUser user, short npcId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FAB")]
	[Cpp2IlInjected.Address(RVA = "0xFABA24", Offset = "0xFABA24", VA = "0xFABA24")]
	private NPCKilledCondition(LocalUser user, short[] npcIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FAC")]
	[Cpp2IlInjected.Address(RVA = "0xFABB00", Offset = "0xFABB00", VA = "0xFABB00", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FAD")]
	[Cpp2IlInjected.Address(RVA = "0xFAB790", Offset = "0xFAB790", VA = "0xFAB790")]
	private static void ListenForPickup(NPCKilledCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FAE")]
	[Cpp2IlInjected.Address(RVA = "0xFABBE4", Offset = "0xFABBE4", VA = "0xFABBE4")]
	private static void NPCKilledListener(Player player, short npcId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FAF")]
	[Cpp2IlInjected.Address(RVA = "0xFABD78", Offset = "0xFABD78", VA = "0xFABD78")]
	public static AchievementCondition Create(LocalUser user, params short[] npcIds)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB0")]
	[Cpp2IlInjected.Address(RVA = "0xFABDE8", Offset = "0xFABDE8", VA = "0xFABDE8")]
	public static AchievementCondition Create(LocalUser user, short npcId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FB1")]
	[Cpp2IlInjected.Address(RVA = "0xFABE58", Offset = "0xFABE58", VA = "0xFABE58")]
	public static AchievementCondition[] CreateMany(LocalUser user, params short[] npcs)
	{
		return null;
	}
}
