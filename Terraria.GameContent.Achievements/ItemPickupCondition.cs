using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000657")]
public class ItemPickupCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x4006CB0")]
	public const string Identifier = "ITEM_PICKUP";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CB1")]
	private readonly LocalUser _user;

	[Cpp2IlInjected.Token(Token = "0x4006CB2")]
	private static Dictionary<short, List<ItemPickupCondition>> _listeners;

	[Cpp2IlInjected.Token(Token = "0x4006CB3")]
	private static bool _isListenerHooked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CB4")]
	private short[] _itemIds;

	[Cpp2IlInjected.Token(Token = "0x6003FA1")]
	[Cpp2IlInjected.Address(RVA = "0xFAAD5C", Offset = "0xFAAD5C", VA = "0xFAAD5C")]
	private ItemPickupCondition(LocalUser user, short itemId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA2")]
	[Cpp2IlInjected.Address(RVA = "0xFAB0E4", Offset = "0xFAB0E4", VA = "0xFAB0E4")]
	private ItemPickupCondition(LocalUser user, short[] itemIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA3")]
	[Cpp2IlInjected.Address(RVA = "0xFAB1C0", Offset = "0xFAB1C0", VA = "0xFAB1C0", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA4")]
	[Cpp2IlInjected.Address(RVA = "0xFAAE50", Offset = "0xFAAE50", VA = "0xFAAE50")]
	private static void ListenForPickup(ItemPickupCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA5")]
	[Cpp2IlInjected.Address(RVA = "0xFAB2A4", Offset = "0xFAB2A4", VA = "0xFAB2A4")]
	private static void ItemPickupListener(Player player, short itemId, int count)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA6")]
	[Cpp2IlInjected.Address(RVA = "0xFAB438", Offset = "0xFAB438", VA = "0xFAB438")]
	public static AchievementCondition Create(LocalUser user, params short[] items)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA7")]
	[Cpp2IlInjected.Address(RVA = "0xFAB4A8", Offset = "0xFAB4A8", VA = "0xFAB4A8")]
	public static AchievementCondition Create(LocalUser user, short item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003FA8")]
	[Cpp2IlInjected.Address(RVA = "0xFAB518", Offset = "0xFAB518", VA = "0xFAB518")]
	public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
	{
		return null;
	}
}
