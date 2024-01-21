using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200033C")]
public struct GetItemSettings
{
	[Cpp2IlInjected.Token(Token = "0x4002EC2")]
	public static GetItemSettings InventoryEntityToPlayerInventorySettings;

	[Cpp2IlInjected.Token(Token = "0x4002EC3")]
	public static GetItemSettings NPCEntityToPlayerInventorySettings;

	[Cpp2IlInjected.Token(Token = "0x4002EC4")]
	public static GetItemSettings LootAllSettings;

	[Cpp2IlInjected.Token(Token = "0x4002EC5")]
	public static GetItemSettings LootAllSettingsRegularChest;

	[Cpp2IlInjected.Token(Token = "0x4002EC6")]
	public static GetItemSettings PickupItemFromWorld;

	[Cpp2IlInjected.Token(Token = "0x4002EC7")]
	public static GetItemSettings GetItemInDropItemCheck;

	[Cpp2IlInjected.Token(Token = "0x4002EC8")]
	public static GetItemSettings InventoryUIToInventorySettings;

	[Cpp2IlInjected.Token(Token = "0x4002EC9")]
	public static GetItemSettings InventoryUIToInventorySettingsShowAsNew;

	[Cpp2IlInjected.Token(Token = "0x4002ECA")]
	public static GetItemSettings ItemCreatedFromItemUsage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002ECB")]
	public readonly bool LongText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4002ECC")]
	public readonly bool NoText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4002ECD")]
	public readonly bool CanGoIntoVoidVault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4002ECE")]
	public readonly Action<Item> StepAfterHandlingSlotNormally;

	[Cpp2IlInjected.Token(Token = "0x60026FF")]
	[Cpp2IlInjected.Address(RVA = "0x39E4A8", Offset = "0x39E4A8", VA = "0x39E4A8")]
	public GetItemSettings(bool LongText = false, bool NoText = false, bool CanGoIntoVoidVault = false, [Optional] Action<Item> StepAfterHandlingSlotNormally)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002700")]
	[Cpp2IlInjected.Address(RVA = "0x39E4C0", Offset = "0x39E4C0", VA = "0x39E4C0")]
	public void HandlePostAction(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002701")]
	[Cpp2IlInjected.Address(RVA = "0x1308F04", Offset = "0x1308F04", VA = "0x1308F04")]
	private static void MakeNewAndShiny(Item item)
	{
	}
}
