using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000656")]
public class ItemCraftCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x4006CAB")]
	public const string Identifier = "ITEM_PICKUP";

	[Cpp2IlInjected.Token(Token = "0x4006CAC")]
	private static Dictionary<short, List<ItemCraftCondition>> _listeners;

	[Cpp2IlInjected.Token(Token = "0x4006CAD")]
	private static bool _isListenerHooked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CAE")]
	private short[] _itemIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CAF")]
	private readonly LocalUser _user;

	[Cpp2IlInjected.Token(Token = "0x6003F98")]
	[Cpp2IlInjected.Address(RVA = "0xFAA41C", Offset = "0xFAA41C", VA = "0xFAA41C")]
	private ItemCraftCondition(LocalUser user, short itemId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F99")]
	[Cpp2IlInjected.Address(RVA = "0xFAA7A4", Offset = "0xFAA7A4", VA = "0xFAA7A4")]
	private ItemCraftCondition(LocalUser user, short[] itemIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9A")]
	[Cpp2IlInjected.Address(RVA = "0xFAA880", Offset = "0xFAA880", VA = "0xFAA880", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9B")]
	[Cpp2IlInjected.Address(RVA = "0xFAA510", Offset = "0xFAA510", VA = "0xFAA510")]
	private static void ListenForCraft(ItemCraftCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9C")]
	[Cpp2IlInjected.Address(RVA = "0xFAA964", Offset = "0xFAA964", VA = "0xFAA964")]
	private static void ItemCraftListener(Player player, short itemId, int count)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9D")]
	[Cpp2IlInjected.Address(RVA = "0xFAAAF8", Offset = "0xFAAAF8", VA = "0xFAAAF8")]
	public static AchievementCondition Create(LocalUser user, params short[] items)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9E")]
	[Cpp2IlInjected.Address(RVA = "0xFAAB68", Offset = "0xFAAB68", VA = "0xFAAB68")]
	public static AchievementCondition Create(LocalUser user, short item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F9F")]
	[Cpp2IlInjected.Address(RVA = "0xFAABD8", Offset = "0xFAABD8", VA = "0xFAABD8")]
	public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
	{
		return null;
	}
}
