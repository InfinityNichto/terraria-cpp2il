using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000641")]
public class ItemFromCatchingNPCBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C83")]
	private int _itemType;

	[Cpp2IlInjected.Token(Token = "0x6003F32")]
	[Cpp2IlInjected.Address(RVA = "0x10FD83C", Offset = "0x10FD83C", VA = "0x10FD83C")]
	public ItemFromCatchingNPCBestiaryInfoElement(int itemId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F33")]
	[Cpp2IlInjected.Address(RVA = "0x10FD85C", Offset = "0x10FD85C", VA = "0x10FD85C", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F34")]
	[Cpp2IlInjected.Address(RVA = "0x10FD94C", Offset = "0x10FD94C", VA = "0x10FD94C", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}
}
