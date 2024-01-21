using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CE")]
public class UICreativeInfiniteItemsDisplay : UIElement
{
	[Cpp2IlInjected.Token(Token = "0x2000AB6")]
	public enum InfiniteItemsDisplayPage
	{
		[Cpp2IlInjected.Token(Token = "0x4008F3E")]
		InfiniteItemsPickup,
		[Cpp2IlInjected.Token(Token = "0x4008F3F")]
		InfiniteItemsResearch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400700A")]
	private List<int> _itemIdsAvailableTotal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400700B")]
	private List<int> _itemIdsAvailableToShow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400700C")]
	private CreativeUnlocksTracker _lastTrackerCheckedForEdits;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400700D")]
	private int _lastCheckedVersionForEdits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400700E")]
	private UISearchBar _searchBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400700F")]
	private UIPanel _searchBoxPanel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4007010")]
	private UIState _parentUIState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4007011")]
	private string _searchString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4007012")]
	private UIDynamicItemCollection _itemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4007013")]
	private EntryFilterer<Item, IItemEntryFilter> _filterer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4007014")]
	private EntrySorter<int, ICreativeItemSortStep> _sorter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4007015")]
	private UIElement _containerInfinites;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4007016")]
	private UIElement _containerSacrifice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4007017")]
	private bool _showSacrificesInsteadOfInfinites;

	[Cpp2IlInjected.Token(Token = "0x4007018")]
	public const string SnapPointName_SacrificeSlot = "CreativeSacrificeSlot";

	[Cpp2IlInjected.Token(Token = "0x4007019")]
	public const string SnapPointName_SacrificeConfirmButton = "CreativeSacrificeConfirm";

	[Cpp2IlInjected.Token(Token = "0x400701A")]
	public const string SnapPointName_InfinitesFilter = "CreativeInfinitesFilter";

	[Cpp2IlInjected.Token(Token = "0x400701B")]
	public const string SnapPointName_InfinitesSearch = "CreativeInfinitesSearch";

	[Cpp2IlInjected.Token(Token = "0x400701C")]
	public const string SnapPointName_InfinitesItemSlot = "CreativeInfinitesSlot";

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400701D")]
	private List<UIImage> _sacrificeCogsSmall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x400701E")]
	private List<UIImage> _sacrificeCogsMedium;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400701F")]
	private List<UIImage> _sacrificeCogsBig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4007020")]
	private UIImageFramed _sacrificePistons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4007021")]
	private UIParticleLayer _pistonParticleSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4007022")]
	private Asset<Texture2D> _pistonParticleAsset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4007023")]
	private int _sacrificeAnimationTimeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4007024")]
	private bool _researchComplete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x4007025")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4007026")]
	private int _lastItemIdSacrificed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4007027")]
	private int _lastItemAmountWeHad;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4007028")]
	private int _lastItemAmountWeNeededTotal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4007029")]
	private bool _didClickSomething;

	[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
	[Cpp2IlInjected.Token(Token = "0x400702A")]
	private bool _didClickSearchBar;

	[Cpp2IlInjected.Token(Token = "0x6004470")]
	[Cpp2IlInjected.Address(RVA = "0x14871F0", Offset = "0x14871F0", VA = "0x14871F0")]
	public UICreativeInfiniteItemsDisplay(UIState uiStateThatHoldsThis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004471")]
	[Cpp2IlInjected.Address(RVA = "0x14877B0", Offset = "0x14877B0", VA = "0x14877B0")]
	private void BuildPage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004472")]
	[Cpp2IlInjected.Address(RVA = "0x1488BE8", Offset = "0x1488BE8", VA = "0x1488BE8")]
	private void Hover_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004473")]
	[Cpp2IlInjected.Address(RVA = "0x1488C74", Offset = "0x1488C74", VA = "0x1488C74")]
	private void Hover_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004474")]
	[Cpp2IlInjected.Address(RVA = "0x1488C80", Offset = "0x1488C80", VA = "0x1488C80")]
	private void Hover_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004475")]
	[Cpp2IlInjected.Address(RVA = "0x1488C8C", Offset = "0x1488C8C", VA = "0x1488C8C")]
	private static UIPanel CreateBasicPanel()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004476")]
	[Cpp2IlInjected.Address(RVA = "0x1488D58", Offset = "0x1488D58", VA = "0x1488D58")]
	private static void SetBasicSizesForCreativeSacrificeOrInfinitesPanel(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004477")]
	[Cpp2IlInjected.Address(RVA = "0x1487960", Offset = "0x1487960", VA = "0x1487960")]
	private void BuildInfinitesMenuContents(UIElement totalContainer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004478")]
	[Cpp2IlInjected.Address(RVA = "0x1487E60", Offset = "0x1487E60", VA = "0x1487E60")]
	private void BuildSacrificeMenuContents(UIElement totalContainer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004479")]
	[Cpp2IlInjected.Address(RVA = "0x148A54C", Offset = "0x148A54C", VA = "0x148A54C")]
	private void research_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447A")]
	[Cpp2IlInjected.Address(RVA = "0x148A628", Offset = "0x148A628", VA = "0x148A628")]
	private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447B")]
	[Cpp2IlInjected.Address(RVA = "0x148A7E4", Offset = "0x148A7E4", VA = "0x148A7E4")]
	private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447C")]
	[Cpp2IlInjected.Address(RVA = "0x1489FF8", Offset = "0x1489FF8", VA = "0x1489FF8")]
	private void AddCogsForSacrificeMenu(UIElement sacrificesContainer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447D")]
	[Cpp2IlInjected.Address(RVA = "0x148ADE0", Offset = "0x148ADE0", VA = "0x148ADE0")]
	private void sacrificeWindow_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447E")]
	[Cpp2IlInjected.Address(RVA = "0x148ADE4", Offset = "0x148ADE4", VA = "0x148ADE4")]
	private void UpdateVisualFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600447F")]
	[Cpp2IlInjected.Address(RVA = "0x148B310", Offset = "0x148B310", VA = "0x148B310")]
	private static void OffsetRotationsForCogs(float rotationOffset, List<UIImage> cogsList)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004480")]
	[Cpp2IlInjected.Address(RVA = "0x148A98C", Offset = "0x148A98C", VA = "0x148A98C")]
	private void AddSymetricalCogsPair(UIElement sacrificesContainer, Vector2 cogOFfsetsInPixels, string assetPath, List<UIImage> imagesList)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004481")]
	[Cpp2IlInjected.Address(RVA = "0x148B4B4", Offset = "0x148B4B4", VA = "0x148B4B4")]
	private void descriptionText_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004482")]
	[Cpp2IlInjected.Address(RVA = "0x148B70C", Offset = "0x148B70C", VA = "0x148B70C")]
	private void sacrificeButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004483")]
	[Cpp2IlInjected.Address(RVA = "0x148B710", Offset = "0x148B710", VA = "0x148B710")]
	public void SacrificeWhatYouCan()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004484")]
	[Cpp2IlInjected.Address(RVA = "0x148B83C", Offset = "0x148B83C", VA = "0x148B83C")]
	public void StopPlayingAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004485")]
	[Cpp2IlInjected.Address(RVA = "0x148B830", Offset = "0x148B830", VA = "0x148B830")]
	private void RememberItemSacrifice(int itemId, int amountWeHave, int amountWeNeedTotal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004486")]
	[Cpp2IlInjected.Address(RVA = "0x148B6F8", Offset = "0x148B6F8", VA = "0x148B6F8")]
	private void ForgetItemSacrifice()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004487")]
	[Cpp2IlInjected.Address(RVA = "0x148B824", Offset = "0x148B824", VA = "0x148B824")]
	private void BeginSacrificeAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004488")]
	[Cpp2IlInjected.Address(RVA = "0x148B884", Offset = "0x148B884", VA = "0x148B884")]
	private void UpdateSacrificeAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004489")]
	[Cpp2IlInjected.Address(RVA = "0x148B26C", Offset = "0x148B26C", VA = "0x148B26C")]
	private float GetSacrificeAnimationProgress()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600448A")]
	[Cpp2IlInjected.Address(RVA = "0x148B898", Offset = "0x148B898", VA = "0x148B898")]
	public void SetPageTypeToShow(InfiniteItemsDisplayPage page)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600448B")]
	[Cpp2IlInjected.Address(RVA = "0x148B8AC", Offset = "0x148B8AC", VA = "0x148B8AC")]
	private void UICreativeInfiniteItemsDisplay_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600448C")]
	[Cpp2IlInjected.Address(RVA = "0x148B998", Offset = "0x148B998", VA = "0x148B998")]
	private void filtersHelper_OnClickingOption()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600448D")]
	[Cpp2IlInjected.Address(RVA = "0x1488A90", Offset = "0x1488A90", VA = "0x1488A90")]
	private void UpdateContents()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600448E")]
	[Cpp2IlInjected.Address(RVA = "0x1488F5C", Offset = "0x1488F5C", VA = "0x1488F5C")]
	private void AddSearchBar(UIElement searchArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600448F")]
	[Cpp2IlInjected.Address(RVA = "0x148C0B8", Offset = "0x148C0B8", VA = "0x148C0B8")]
	private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004490")]
	[Cpp2IlInjected.Address(RVA = "0x148C148", Offset = "0x148C148", VA = "0x148C148")]
	private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004491")]
	[Cpp2IlInjected.Address(RVA = "0x148C184", Offset = "0x148C184", VA = "0x148C184")]
	private void OnCanceledInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004492")]
	[Cpp2IlInjected.Address(RVA = "0x148C200", Offset = "0x148C200", VA = "0x148C200")]
	private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004493")]
	[Cpp2IlInjected.Address(RVA = "0x148C2E4", Offset = "0x148C2E4", VA = "0x148C2E4", Slot = "17")]
	public override void LeftClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004494")]
	[Cpp2IlInjected.Address(RVA = "0x148C310", Offset = "0x148C310", VA = "0x148C310", Slot = "21")]
	public override void RightClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004495")]
	[Cpp2IlInjected.Address(RVA = "0x148C304", Offset = "0x148C304", VA = "0x148C304")]
	private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004496")]
	[Cpp2IlInjected.Address(RVA = "0x148C330", Offset = "0x148C330", VA = "0x148C330", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004497")]
	[Cpp2IlInjected.Address(RVA = "0x148C37C", Offset = "0x148C37C", VA = "0x148C37C")]
	private void OnSearchContentsChanged(string contents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004498")]
	[Cpp2IlInjected.Address(RVA = "0x148C3EC", Offset = "0x148C3EC", VA = "0x148C3EC")]
	private void OnStartTakingInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004499")]
	[Cpp2IlInjected.Address(RVA = "0x148C470", Offset = "0x148C470", VA = "0x148C470")]
	private void OnEndTakingInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600449A")]
	[Cpp2IlInjected.Address(RVA = "0x148C4B0", Offset = "0x148C4B0", VA = "0x148C4B0")]
	private void OpenVirtualKeyboardWhenNeeded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600449B")]
	[Cpp2IlInjected.Address(RVA = "0x148C638", Offset = "0x148C638", VA = "0x148C638")]
	private bool EscapeVirtualKeyboard()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600449C")]
	[Cpp2IlInjected.Address(RVA = "0x148C704", Offset = "0x148C704", VA = "0x148C704")]
	private static UserInterface GetCurrentInterface()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600449D")]
	[Cpp2IlInjected.Address(RVA = "0x148C810", Offset = "0x148C810", VA = "0x148C810")]
	private void OnFinishedSettingName(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600449E")]
	[Cpp2IlInjected.Address(RVA = "0x148C844", Offset = "0x148C844", VA = "0x148C844")]
	private void GoBackHere()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600449F")]
	[Cpp2IlInjected.Address(RVA = "0x148C8EC", Offset = "0x148C8EC", VA = "0x148C8EC")]
	public int GetItemsPerLine()
	{
		return default(int);
	}
}
