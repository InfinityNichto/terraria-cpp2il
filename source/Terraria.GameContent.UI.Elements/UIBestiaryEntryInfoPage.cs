using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C3")]
public class UIBestiaryEntryInfoPage : UIPanel
{
	[Cpp2IlInjected.Token(Token = "0x2000AB3")]
	private enum BestiaryInfoCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4008F30")]
		Nameplate,
		[Cpp2IlInjected.Token(Token = "0x4008F31")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x4008F32")]
		FlavorText,
		[Cpp2IlInjected.Token(Token = "0x4008F33")]
		Stats,
		[Cpp2IlInjected.Token(Token = "0x4008F34")]
		ItemsFromCatchingNPC,
		[Cpp2IlInjected.Token(Token = "0x4008F35")]
		ItemsFromDrops,
		[Cpp2IlInjected.Token(Token = "0x4008F36")]
		Misc
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FD6")]
	private UIList _list;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FD7")]
	private UIScrollbar _scrollbar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FD8")]
	private bool _isScrollbarAttached;

	[Cpp2IlInjected.Token(Token = "0x600442D")]
	[Cpp2IlInjected.Address(RVA = "0x147E07C", Offset = "0x147E07C", VA = "0x147E07C")]
	public UIBestiaryEntryInfoPage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600442E")]
	[Cpp2IlInjected.Address(RVA = "0x147EC00", Offset = "0x147EC00", VA = "0x147EC00")]
	public void UpdateScrollbar(int scrollWheelValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600442F")]
	[Cpp2IlInjected.Address(RVA = "0x147EAC0", Offset = "0x147EAC0", VA = "0x147EAC0")]
	private void AppendBorderOverEverything()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004430")]
	[Cpp2IlInjected.Address(RVA = "0x147EC80", Offset = "0x147EC80", VA = "0x147EC80")]
	private void ManualIfnoSortingMethod(List<UIElement> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004431")]
	[Cpp2IlInjected.Address(RVA = "0x147EC84", Offset = "0x147EC84", VA = "0x147EC84", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004432")]
	[Cpp2IlInjected.Address(RVA = "0x147EA64", Offset = "0x147EA64", VA = "0x147EA64")]
	private void CheckScrollBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004433")]
	[Cpp2IlInjected.Address(RVA = "0x147ECC0", Offset = "0x147ECC0", VA = "0x147ECC0")]
	public void FillInfoForEntry(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004434")]
	[Cpp2IlInjected.Address(RVA = "0x147F6C4", Offset = "0x147F6C4", VA = "0x147F6C4")]
	private BestiaryUICollectionInfo GetUICollectionInfo(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6004435")]
	[Cpp2IlInjected.Address(RVA = "0x147ED30", Offset = "0x147ED30", VA = "0x147ED30")]
	private void AddInfoToList(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004436")]
	[Cpp2IlInjected.Address(RVA = "0x147FA6C", Offset = "0x147FA6C", VA = "0x147FA6C")]
	private float GetIndividualElementPriority(IBestiaryInfoElement element)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004437")]
	[Cpp2IlInjected.Address(RVA = "0x147FB48", Offset = "0x147FB48", VA = "0x147FB48")]
	private BestiaryInfoCategory GetBestiaryInfoCategory(IBestiaryInfoElement element)
	{
		return default(BestiaryInfoCategory);
	}
}
