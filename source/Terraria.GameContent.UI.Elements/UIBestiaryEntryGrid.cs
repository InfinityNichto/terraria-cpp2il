using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BE")]
public class UIBestiaryEntryGrid : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FBB")]
	private List<BestiaryEntry> _workingSetEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FBC")]
	private MouseEvent _clickOnEntryEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FBD")]
	private int _atEntryIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006FBE")]
	private int _lastEntry;

	[Cpp2IlInjected.Token(Token = "0x14000056")]
	public event Action OnGridContentsChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6004402")]
		[Cpp2IlInjected.Address(RVA = "0x11930D8", Offset = "0x11930D8", VA = "0x11930D8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004403")]
		[Cpp2IlInjected.Address(RVA = "0x1193188", Offset = "0x1193188", VA = "0x1193188")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004404")]
	[Cpp2IlInjected.Address(RVA = "0x1193238", Offset = "0x1193238", VA = "0x1193238")]
	public UIBestiaryEntryGrid(List<BestiaryEntry> workingSet, MouseEvent clickOnEntryEvent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004405")]
	[Cpp2IlInjected.Address(RVA = "0x119337C", Offset = "0x119337C", VA = "0x119337C")]
	public void UpdateEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004406")]
	[Cpp2IlInjected.Address(RVA = "0x11933CC", Offset = "0x11933CC", VA = "0x11933CC")]
	public void FillBestiarySpaceWithEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004407")]
	[Cpp2IlInjected.Address(RVA = "0x11938E0", Offset = "0x11938E0", VA = "0x11938E0", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004408")]
	[Cpp2IlInjected.Address(RVA = "0x1193768", Offset = "0x1193768", VA = "0x1193768")]
	public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004409")]
	[Cpp2IlInjected.Address(RVA = "0x1193900", Offset = "0x1193900", VA = "0x1193900")]
	public string GetRangeText()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600440A")]
	[Cpp2IlInjected.Address(RVA = "0x1193A60", Offset = "0x1193A60", VA = "0x1193A60")]
	public void MakeButtonGoByOffset(UIElement element, int howManyPages)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600440B")]
	[Cpp2IlInjected.Address(RVA = "0x1193B1C", Offset = "0x1193B1C", VA = "0x1193B1C")]
	public void OffsetLibraryByPages(int howManyPages)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600440C")]
	[Cpp2IlInjected.Address(RVA = "0x1193B8C", Offset = "0x1193B8C", VA = "0x1193B8C")]
	public void OffsetLibrary(int offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600440D")]
	[Cpp2IlInjected.Address(RVA = "0x11937E0", Offset = "0x11937E0", VA = "0x11937E0")]
	private void FixBestiaryRange(int offset, int maxEntriesToHave)
	{
	}
}
