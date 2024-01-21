using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C1")]
public class UICreativeItemsInfiniteFilteringOptions : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FCB")]
	private EntryFilterer<Item, IItemEntryFilter> _filterer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FCC")]
	private Dictionary<UIImageFramed, IItemEntryFilter> _filtersByButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FCD")]
	private Dictionary<UIImageFramed, UIElement> _iconsByButtons;

	[Cpp2IlInjected.Token(Token = "0x4006FCF")]
	private const int barFramesX = 2;

	[Cpp2IlInjected.Token(Token = "0x4006FD0")]
	private const int barFramesY = 4;

	[Cpp2IlInjected.Token(Token = "0x14000059")]
	public event Action OnClickingOption
	{
		[Cpp2IlInjected.Token(Token = "0x6004421")]
		[Cpp2IlInjected.Address(RVA = "0x1489F48", Offset = "0x1489F48", VA = "0x1489F48")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004422")]
		[Cpp2IlInjected.Address(RVA = "0x148C9B0", Offset = "0x148C9B0", VA = "0x148C9B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004423")]
	[Cpp2IlInjected.Address(RVA = "0x14898F8", Offset = "0x14898F8", VA = "0x14898F8")]
	public UICreativeItemsInfiniteFilteringOptions(EntryFilterer<Item, IItemEntryFilter> filterer, string snapPointsName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004424")]
	[Cpp2IlInjected.Address(RVA = "0x148CD90", Offset = "0x148CD90", VA = "0x148CD90")]
	private void button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004425")]
	[Cpp2IlInjected.Address(RVA = "0x148CDCC", Offset = "0x148CDCC", VA = "0x148CDCC")]
	private void singleFilterButtonClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004426")]
	[Cpp2IlInjected.Address(RVA = "0x148CB64", Offset = "0x148CB64", VA = "0x148CB64")]
	private void UpdateVisuals(UIImageFramed button, int indexOfFilter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004427")]
	[Cpp2IlInjected.Address(RVA = "0x148CA60", Offset = "0x148CA60", VA = "0x148CA60")]
	private void AddOnHover(IItemEntryFilter filter, UIElement button, int indexOfFilter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004428")]
	[Cpp2IlInjected.Address(RVA = "0x148CF4C", Offset = "0x148CF4C", VA = "0x148CF4C")]
	private void ShowButtonName(UIElement element, IItemEntryFilter number, int indexOfFilter)
	{
	}
}
