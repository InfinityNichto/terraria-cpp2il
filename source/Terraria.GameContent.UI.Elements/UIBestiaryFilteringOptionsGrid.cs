using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C0")]
public class UIBestiaryFilteringOptionsGrid : UIPanel
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FC5")]
	private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FC6")]
	private List<GroupOptionButton<int>> _filterButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FC7")]
	private List<bool> _areFiltersAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006FC8")]
	private List<List<BestiaryEntry>> _filterAvailabilityTests;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4006FCA")]
	private UIElement _container;

	[Cpp2IlInjected.Token(Token = "0x14000058")]
	public event Action OnClickingOption
	{
		[Cpp2IlInjected.Token(Token = "0x6004414")]
		[Cpp2IlInjected.Address(RVA = "0x147FE54", Offset = "0x147FE54", VA = "0x147FE54")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6004415")]
		[Cpp2IlInjected.Address(RVA = "0x147FF04", Offset = "0x147FF04", VA = "0x147FF04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004416")]
	[Cpp2IlInjected.Address(RVA = "0x147FFB4", Offset = "0x147FFB4", VA = "0x147FFB4")]
	public UIBestiaryFilteringOptionsGrid(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004417")]
	[Cpp2IlInjected.Address(RVA = "0x14801B0", Offset = "0x14801B0", VA = "0x14801B0")]
	private void BuildContainer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004418")]
	[Cpp2IlInjected.Address(RVA = "0x1480544", Offset = "0x1480544", VA = "0x1480544")]
	public void SetupAvailabilityTest(List<BestiaryEntry> allAvailableEntries)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004419")]
	[Cpp2IlInjected.Address(RVA = "0x1480760", Offset = "0x1480760", VA = "0x1480760")]
	public void UpdateAvailability()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600441A")]
	[Cpp2IlInjected.Address(RVA = "0x1481700", Offset = "0x1481700", VA = "0x1481700")]
	public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600441B")]
	[Cpp2IlInjected.Address(RVA = "0x1480420", Offset = "0x1480420", VA = "0x1480420")]
	private void GetDisplaySettings(out int widthPerButton, out int heightPerButton, out int widthWithSpacing, out int heightWithSpacing, out int perRow, out float offsetLeft, out float offsetTop, out int howManyRows)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600441C")]
	[Cpp2IlInjected.Address(RVA = "0x1481524", Offset = "0x1481524", VA = "0x1481524")]
	private void UpdateButtonSelections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600441D")]
	[Cpp2IlInjected.Address(RVA = "0x14810D8", Offset = "0x14810D8", VA = "0x14810D8")]
	private bool GetIsFilterAvailableForEntries(IBestiaryEntryFilter filter, List<BestiaryEntry> entries)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600441E")]
	[Cpp2IlInjected.Address(RVA = "0x1481348", Offset = "0x1481348", VA = "0x1481348")]
	private void AddOnHover(IBestiaryEntryFilter filter, UIElement button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600441F")]
	[Cpp2IlInjected.Address(RVA = "0x14817E0", Offset = "0x14817E0", VA = "0x14817E0")]
	private void ShowButtonName(UIElement element, IBestiaryEntryFilter number)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004420")]
	[Cpp2IlInjected.Address(RVA = "0x1481928", Offset = "0x1481928", VA = "0x1481928")]
	private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
	{
	}
}
