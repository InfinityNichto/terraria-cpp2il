using Cpp2IlInjected;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000640")]
public class ItemDropBestiaryInfoElement : IItemBestiaryInfoElement, IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C82")]
	public DropRateInfo _droprateInfo;

	[Cpp2IlInjected.Token(Token = "0x6003F2D")]
	[Cpp2IlInjected.Address(RVA = "0x10FD528", Offset = "0x10FD528", VA = "0x10FD528")]
	public ItemDropBestiaryInfoElement(DropRateInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F2E")]
	[Cpp2IlInjected.Address(RVA = "0x10FD568", Offset = "0x10FD568", VA = "0x10FD568")]
	public bool ShouldShowItem()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F2F")]
	[Cpp2IlInjected.Address(RVA = "0x10FD698", Offset = "0x10FD698", VA = "0x10FD698", Slot = "6")]
	public virtual UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F30")]
	[Cpp2IlInjected.Address(RVA = "0x10FD570", Offset = "0x10FD570", VA = "0x10FD570")]
	private static bool ShouldShowItem(ref DropRateInfo dropRateInfo)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F31")]
	[Cpp2IlInjected.Address(RVA = "0x10FD774", Offset = "0x10FD774", VA = "0x10FD774", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}
}
