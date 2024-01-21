using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class GUIItemFilter
{
	[Cpp2IlInjected.Token(Token = "0x20007BD")]
	public enum CategoryFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4007A13")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4007A14")]
		Weapon,
		[Cpp2IlInjected.Token(Token = "0x4007A15")]
		Armor,
		[Cpp2IlInjected.Token(Token = "0x4007A16")]
		Vanity,
		[Cpp2IlInjected.Token(Token = "0x4007A17")]
		BuildingBlock,
		[Cpp2IlInjected.Token(Token = "0x4007A18")]
		Furniture,
		[Cpp2IlInjected.Token(Token = "0x4007A19")]
		Accessories,
		[Cpp2IlInjected.Token(Token = "0x4007A1A")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4007A1B")]
		Consumables,
		[Cpp2IlInjected.Token(Token = "0x4007A1C")]
		Tools,
		[Cpp2IlInjected.Token(Token = "0x4007A1D")]
		Materials,
		[Cpp2IlInjected.Token(Token = "0x4007A1E")]
		GameplayItems,
		[Cpp2IlInjected.Token(Token = "0x4007A1F")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private GUIPageIcons.Category _cat;

	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private static string[] categoryName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	public CategoryFilter ActiveCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	public string SearchTerm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	public bool Expanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	public bool editingSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	public string editSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	public string editSearchStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	public string editDisplaySearch;

	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private static List<IItemEntryFilter> everythingButMisc;

	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private static IItemEntryFilter[] CategoryFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private ISearchFilter<Item> searchFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private bool disableReset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private bool miscFilterInitialised;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private float collapseScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private float allScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private float weaponScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private float armorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private float vanityScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private float buildingBlockScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private float furnitureScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private float gameplayItemsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private float accessoriesScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private float equipmentScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private float consumablesScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private float toolsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float materialsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public GUIControllerItemFilter _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private GUIControllerItem previousNavigationItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private static float BeginSearchScale;

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x136B9CC", Offset = "0x136B9CC", VA = "0x136B9CC")]
	public GUIItemFilter(GUIPageIcons.Category cat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x136BAB0", Offset = "0x136BAB0", VA = "0x136BAB0")]
	public void Reset(bool expandedOnTouch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x136BC3C", Offset = "0x136BC3C", VA = "0x136BC3C")]
	public void SetFilterCategory(CategoryFilter category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x136BB54", Offset = "0x136BB54", VA = "0x136BB54")]
	public void SetSearchTerm(string term)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x1369E98", Offset = "0x1369E98", VA = "0x1369E98")]
	public bool Matches(int itemId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x136BC44", Offset = "0x136BC44", VA = "0x136BC44")]
	public void CloseExpandedFilter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x136BCD8", Offset = "0x136BCD8", VA = "0x136BCD8")]
	private void LoadCategoryButtonIcon(TransactionButton_Layout button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x136BE20", Offset = "0x136BE20", VA = "0x136BE20")]
	private void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x136BEC4", Offset = "0x136BEC4", VA = "0x136BEC4")]
	public void DrawFilter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x136DAE8", Offset = "0x136DAE8", VA = "0x136DAE8")]
	private void DrawSearch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x136E234", Offset = "0x136E234", VA = "0x136E234")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}
}
