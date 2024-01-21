using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States;

[Cpp2IlInjected.Token(Token = "0x20006A7")]
public class UIBestiaryTest : UIState
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006ED7")]
	private UIElement _bestiarySpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006ED8")]
	private UIBestiaryEntryInfoPage _infoSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006ED9")]
	private UIBestiaryEntryButton _selectedEntryButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006EDA")]
	private List<BestiaryEntry> _originalEntriesList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006EDB")]
	private List<BestiaryEntry> _workingSetEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006EDC")]
	private UIText _indexesRangeText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006EDD")]
	private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006EDE")]
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006EDF")]
	private UIBestiaryEntryGrid _entryGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006EE0")]
	private UIBestiarySortingOptionsGrid _sortingGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4006EE1")]
	private UIBestiaryFilteringOptionsGrid _filteringGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4006EE2")]
	private UISearchBar _searchBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4006EE3")]
	private UIPanel _searchBoxPanel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4006EE4")]
	private UIText _sortingText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4006EE5")]
	private UIText _filteringText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4006EE6")]
	private string _searchString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4006EE7")]
	private BestiaryUnlockProgressReport _progressReport;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4006EE8")]
	private UIText _progressPercentText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4006EE9")]
	private UIColoredSliderSimple _unlocksProgressBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4006EEA")]
	private bool _didClickSomething;

	[Cpp2IlInjected.FieldOffset(Offset = "0x141")]
	[Cpp2IlInjected.Token(Token = "0x4006EEB")]
	private bool _didClickSearchBar;

	[Cpp2IlInjected.Token(Token = "0x60042DF")]
	[Cpp2IlInjected.Address(RVA = "0x10A996C", Offset = "0x10A996C", VA = "0x10A996C")]
	public UIBestiaryTest(BestiaryDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E0")]
	[Cpp2IlInjected.Address(RVA = "0x10AA304", Offset = "0x10AA304", VA = "0x10AA304")]
	public void OnOpenPage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E1")]
	[Cpp2IlInjected.Address(RVA = "0x10A9AFC", Offset = "0x10A9AFC", VA = "0x10A9AFC")]
	private void BuildPage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E2")]
	[Cpp2IlInjected.Address(RVA = "0x10AB5F4", Offset = "0x10AB5F4", VA = "0x10AB5F4")]
	private void FillProgressBottomBar(UIElement container)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E3")]
	[Cpp2IlInjected.Address(RVA = "0x10ABE3C", Offset = "0x10ABE3C", VA = "0x10ABE3C")]
	private void ShowStats_Completion(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E4")]
	[Cpp2IlInjected.Address(RVA = "0x10ABF0C", Offset = "0x10ABF0C", VA = "0x10ABF0C")]
	private string GetCompletionPercentText()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60042E5")]
	[Cpp2IlInjected.Address(RVA = "0x10ABFFC", Offset = "0x10ABFFC", VA = "0x10ABFFC")]
	private float GetProgressPercent()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60042E6")]
	[Cpp2IlInjected.Address(RVA = "0x10AC008", Offset = "0x10AC008", VA = "0x10AC008")]
	private void EmptyInteraction(float input)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E7")]
	[Cpp2IlInjected.Address(RVA = "0x10AC00C", Offset = "0x10AC00C", VA = "0x10AC00C")]
	private void EmptyInteraction2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042E8")]
	[Cpp2IlInjected.Address(RVA = "0x10AC010", Offset = "0x10AC010", VA = "0x10AC010")]
	private Color GetColorAtBlip(float percentile)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60042E9")]
	[Cpp2IlInjected.Address(RVA = "0x10AB7C8", Offset = "0x10AB7C8", VA = "0x10AB7C8")]
	private void AddBackAndForwardButtons(UIElement innerTopContainer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042EA")]
	[Cpp2IlInjected.Address(RVA = "0x10AA67C", Offset = "0x10AA67C", VA = "0x10AA67C")]
	private void AddSortAndFilterButtons(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042EB")]
	[Cpp2IlInjected.Address(RVA = "0x10AADAC", Offset = "0x10AADAC", VA = "0x10AADAC")]
	private void AddSearchBar(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042EC")]
	[Cpp2IlInjected.Address(RVA = "0x10AC084", Offset = "0x10AC084", VA = "0x10AC084")]
	private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042ED")]
	[Cpp2IlInjected.Address(RVA = "0x10AC0F8", Offset = "0x10AC0F8", VA = "0x10AC0F8")]
	private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042EE")]
	[Cpp2IlInjected.Address(RVA = "0x10AC134", Offset = "0x10AC134", VA = "0x10AC134")]
	private void OpenVirtualKeyboardWhenNeeded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042EF")]
	[Cpp2IlInjected.Address(RVA = "0x10AC2A4", Offset = "0x10AC2A4", VA = "0x10AC2A4")]
	private void OnFinishedSettingName(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F0")]
	[Cpp2IlInjected.Address(RVA = "0x10AC2DC", Offset = "0x10AC2DC", VA = "0x10AC2DC")]
	private void GoBackHere()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F1")]
	[Cpp2IlInjected.Address(RVA = "0x10AC370", Offset = "0x10AC370", VA = "0x10AC370")]
	private void OnStartTakingInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F2")]
	[Cpp2IlInjected.Address(RVA = "0x10AC3F4", Offset = "0x10AC3F4", VA = "0x10AC3F4")]
	private void OnEndTakingInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F3")]
	[Cpp2IlInjected.Address(RVA = "0x10AC434", Offset = "0x10AC434", VA = "0x10AC434")]
	private void OnSearchContentsChanged(string contents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F4")]
	[Cpp2IlInjected.Address(RVA = "0x10AC4A4", Offset = "0x10AC4A4", VA = "0x10AC4A4")]
	private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F5")]
	[Cpp2IlInjected.Address(RVA = "0x10AC4DC", Offset = "0x10AC4DC", VA = "0x10AC4DC", Slot = "17")]
	public override void LeftClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F6")]
	[Cpp2IlInjected.Address(RVA = "0x10AC508", Offset = "0x10AC508", VA = "0x10AC508", Slot = "21")]
	public override void RightClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F7")]
	[Cpp2IlInjected.Address(RVA = "0x10AC4FC", Offset = "0x10AC4FC", VA = "0x10AC4FC")]
	private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F8")]
	[Cpp2IlInjected.Address(RVA = "0x10AC528", Offset = "0x10AC528", VA = "0x10AC528", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042F9")]
	[Cpp2IlInjected.Address(RVA = "0x10AC57C", Offset = "0x10AC57C", VA = "0x10AC57C")]
	private void FilterEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FA")]
	[Cpp2IlInjected.Address(RVA = "0x10AC660", Offset = "0x10AC660", VA = "0x10AC660")]
	private void SortEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FB")]
	[Cpp2IlInjected.Address(RVA = "0x10AC938", Offset = "0x10AC938", VA = "0x10AC938")]
	private void FillBestiarySpaceWithEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FC")]
	[Cpp2IlInjected.Address(RVA = "0x10ACB38", Offset = "0x10ACB38", VA = "0x10ACB38")]
	public void UpdateBestiaryGridRange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FD")]
	[Cpp2IlInjected.Address(RVA = "0x10ACB64", Offset = "0x10ACB64", VA = "0x10ACB64", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FE")]
	[Cpp2IlInjected.Address(RVA = "0x10ACB84", Offset = "0x10ACB84", VA = "0x10ACB84")]
	private void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042FF")]
	[Cpp2IlInjected.Address(RVA = "0x10AA414", Offset = "0x10AA414", VA = "0x10AA414")]
	private void MakeExitButton(UIElement outerContainer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004300")]
	[Cpp2IlInjected.Address(RVA = "0x10ACC08", Offset = "0x10ACC08", VA = "0x10ACC08")]
	private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004301")]
	[Cpp2IlInjected.Address(RVA = "0x10ACCF0", Offset = "0x10ACCF0", VA = "0x10ACCF0")]
	private void OpenOrCloseSortingOptions(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004302")]
	[Cpp2IlInjected.Address(RVA = "0x10ACD7C", Offset = "0x10ACD7C", VA = "0x10ACD7C")]
	private void OpenOrCloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004303")]
	[Cpp2IlInjected.Address(RVA = "0x10ACE0C", Offset = "0x10ACE0C", VA = "0x10ACE0C")]
	private void Click_CloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004304")]
	[Cpp2IlInjected.Address(RVA = "0x10ACDE8", Offset = "0x10ACDE8", VA = "0x10ACDE8")]
	private void CloseFilteringGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004305")]
	[Cpp2IlInjected.Address(RVA = "0x10AA308", Offset = "0x10AA308", VA = "0x10AA308")]
	private void UpdateBestiaryContents()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004306")]
	[Cpp2IlInjected.Address(RVA = "0x10ACE44", Offset = "0x10ACE44", VA = "0x10ACE44")]
	private void Click_CloseSortingGrid(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004307")]
	[Cpp2IlInjected.Address(RVA = "0x10ACD58", Offset = "0x10ACD58", VA = "0x10ACD58")]
	private void CloseSortingGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004308")]
	[Cpp2IlInjected.Address(RVA = "0x10ACE7C", Offset = "0x10ACE7C", VA = "0x10ACE7C")]
	private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004309")]
	[Cpp2IlInjected.Address(RVA = "0x10AD038", Offset = "0x10AD038", VA = "0x10AD038")]
	private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600430A")]
	[Cpp2IlInjected.Address(RVA = "0x10AD1E0", Offset = "0x10AD1E0", VA = "0x10AD1E0")]
	private void Click_SelectEntryButton(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600430B")]
	[Cpp2IlInjected.Address(RVA = "0x10AD284", Offset = "0x10AD284", VA = "0x10AD284")]
	private void SelectEntryButton(UIBestiaryEntryButton button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600430C")]
	[Cpp2IlInjected.Address(RVA = "0x10AC9A8", Offset = "0x10AC9A8", VA = "0x10AC9A8")]
	private void DeselectEntryButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600430D")]
	[Cpp2IlInjected.Address(RVA = "0x10AC9D8", Offset = "0x10AC9D8", VA = "0x10AC9D8")]
	public BestiaryUnlockProgressReport GetUnlockProgress()
	{
		return default(BestiaryUnlockProgressReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600430E")]
	[Cpp2IlInjected.Address(RVA = "0x10AD2D8", Offset = "0x10AD2D8", VA = "0x10AD2D8", Slot = "8")]
	public override void Draw(SpriteBatch spriteBatch)
	{
	}
}
