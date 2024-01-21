using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class GUIPageIcons
{
	[Cpp2IlInjected.Token(Token = "0x20007C3")]
	public enum PageControlsType
	{
		[Cpp2IlInjected.Token(Token = "0x4007A49")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x4007A4A")]
		Bottom
	}

	[Cpp2IlInjected.Token(Token = "0x20007C4")]
	public enum PageCollapseMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007A4C")]
		CollapsedFullClosed,
		[Cpp2IlInjected.Token(Token = "0x4007A4D")]
		FullClosed,
		[Cpp2IlInjected.Token(Token = "0x4007A4E")]
		CollapsedFull,
		[Cpp2IlInjected.Token(Token = "0x4007A4F")]
		FullOnly
	}

	[Cpp2IlInjected.Token(Token = "0x20007C5")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007A51")]
		Crafting,
		[Cpp2IlInjected.Token(Token = "0x4007A52")]
		CraftingGuide,
		[Cpp2IlInjected.Token(Token = "0x4007A53")]
		Inventory,
		[Cpp2IlInjected.Token(Token = "0x4007A54")]
		Chest,
		[Cpp2IlInjected.Token(Token = "0x4007A55")]
		Shop,
		[Cpp2IlInjected.Token(Token = "0x4007A56")]
		Housing,
		[Cpp2IlInjected.Token(Token = "0x4007A57")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4007A58")]
		PVP,
		[Cpp2IlInjected.Token(Token = "0x4007A59")]
		Map,
		[Cpp2IlInjected.Token(Token = "0x4007A5A")]
		Reforge,
		[Cpp2IlInjected.Token(Token = "0x4007A5B")]
		HairStylist,
		[Cpp2IlInjected.Token(Token = "0x4007A5C")]
		Dresser,
		[Cpp2IlInjected.Token(Token = "0x4007A5D")]
		GrandDesignSettings,
		[Cpp2IlInjected.Token(Token = "0x4007A5E")]
		JourneyModeSettings,
		[Cpp2IlInjected.Token(Token = "0x4007A5F")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x4007A60")]
		Duplicate,
		[Cpp2IlInjected.Token(Token = "0x4007A61")]
		DisplayDoll,
		[Cpp2IlInjected.Token(Token = "0x4007A62")]
		HatRack,
		[Cpp2IlInjected.Token(Token = "0x4007A63")]
		Research,
		[Cpp2IlInjected.Token(Token = "0x4007A64")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007A65")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	public PageCollapseMode PageMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	public PageControlsType PageControls;

	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private static Texture2D[] _categories;

	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private static Texture2D[] _categoriesSelected;

	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private static Dictionary<int, Texture2D> _npcIcons;

	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private static Dictionary<int, Texture2D> _npcSelectedIcons;

	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static Dictionary<int, Texture2D> _npcShimmeredIcons;

	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private static Dictionary<int, Texture2D> _npcShimmeredSelectedIcons;

	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private static Dictionary<int, Texture2D> _itemIcons;

	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private static Dictionary<int, Texture2D> _itemSelectedIcons;

	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private static Texture2D _menuClosed;

	[Cpp2IlInjected.Token(Token = "0x400071E")]
	public static Texture2D _menuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private Category lastHoverLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private Category hoverLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private float TimeSinceLeftHoverChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private float TimeSinceLeftChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private float TimeSinceRightChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private Category lastHoverRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private Category hoverRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private float TimeSinceRightHoverChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	public bool UseHorizontalInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	public bool UseConsoleStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	public bool EnableDoubleClick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	public bool UsePageLeftStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	public bool leftMenuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private bool leftMenuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private DateTime LeftNavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private float leftMenuButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private Category _selectedLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public bool excludeFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public List<Category> leftItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public List<Category> craftItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public List<Category> interactionItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public List<Category> equipmentItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public bool rightMenuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private float rightMenuButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private Category _selectedRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private Category _selectedCrafting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private Category _selectedInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private Category _selectedEquipment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private bool rightMenuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private DateTime RightNavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	public List<Category> rightItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	public bool rightUseDuplication;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	public bool rightUseItemFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private Vector2 pageButtonRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public GUIControllerItem lastActive;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool UseHorizontalPages
	{
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x100A494", Offset = "0x100A494", VA = "0x100A494")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool UsingTouchUI
	{
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xFFC364", Offset = "0xFFC364", VA = "0xFFC364")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool DisplayTouchOptions
	{
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xFFC458", Offset = "0xFFC458", VA = "0xFFC458")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public Category selectedLeft
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x100B1A4", Offset = "0x100B1A4", VA = "0x100B1A4")]
		get
		{
			return default(Category);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x100B1AC", Offset = "0x100B1AC", VA = "0x100B1AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public Category selectedRight
	{
		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x100B1E4", Offset = "0x100B1E4", VA = "0x100B1E4")]
		get
		{
			return default(Category);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x100B1EC", Offset = "0x100B1EC", VA = "0x100B1EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool PagePopupDisplayed
	{
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x1005D3C", Offset = "0x1005D3C", VA = "0x1005D3C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool LastActiveLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x100FBE8", Offset = "0x100FBE8", VA = "0x100FBE8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x100A4B4", Offset = "0x100A4B4", VA = "0x100A4B4")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x100AEDC", Offset = "0x100AEDC", VA = "0x100AEDC")]
	private static void LoadItemIcon(ContentManager content, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x100AB68", Offset = "0x100AB68", VA = "0x100AB68")]
	private static void LoadNPCIcon(ContentManager content, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x100216C", Offset = "0x100216C", VA = "0x100216C")]
	public Texture2D GetCategoryTexture(Category category, bool selected)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0xFFA510", Offset = "0xFFA510", VA = "0xFFA510")]
	public bool IsPageSelected(Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x100B158", Offset = "0x100B158", VA = "0x100B158")]
	public bool DrawRightPageHUD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x1007EB0", Offset = "0x1007EB0", VA = "0x1007EB0")]
	public bool CanAcceptItems(Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0xFFD8AC", Offset = "0xFFD8AC", VA = "0xFFD8AC")]
	public void Close(bool hideChat = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x10072D4", Offset = "0x10072D4", VA = "0x10072D4")]
	public void OpenUI(Category left, Category right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x100BA38", Offset = "0x100BA38", VA = "0x100BA38")]
	private void RefreshLeftItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x100B224", Offset = "0x100B224", VA = "0x100B224")]
	private void RefreshRightItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x100BB1C", Offset = "0x100BB1C", VA = "0x100BB1C")]
	private void RefreshAvailableItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x100BE54", Offset = "0x100BE54", VA = "0x100BE54")]
	private void UpdatePageStates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x100BFC4", Offset = "0x100BFC4", VA = "0x100BFC4")]
	public float ExtendedScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x100BFCC", Offset = "0x100BFCC", VA = "0x100BFCC")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x1004FBC", Offset = "0x1004FBC", VA = "0x1004FBC")]
	public void OnCategoryClosed(Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x1005394", Offset = "0x1005394", VA = "0x1005394")]
	public void OnCategoryOpened(Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x100C028", Offset = "0x100C028", VA = "0x100C028")]
	private void LeftOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x100C62C", Offset = "0x100C62C", VA = "0x100C62C")]
	private void InventoryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x100C920", Offset = "0x100C920", VA = "0x100C920")]
	private void LeftDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x100D234", Offset = "0x100D234", VA = "0x100D234")]
	private void RightOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x100D7FC", Offset = "0x100D7FC", VA = "0x100D7FC")]
	public bool AnyPageSelected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x100DA60", Offset = "0x100DA60", VA = "0x100DA60")]
	public bool IsLeftPageSelected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x100B194", Offset = "0x100B194", VA = "0x100B194")]
	public bool IsRightPageSelected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x1008A08", Offset = "0x1008A08", VA = "0x1008A08")]
	public void LoadDrawColor(TransactionButton_Layout layout, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x100830C", Offset = "0x100830C", VA = "0x100830C")]
	public void OverloadDrawColor(TransactionButton_Layout layout, Category category, bool over, bool selected, out Color restoreCol)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0x100DA70", Offset = "0x100DA70", VA = "0x100DA70")]
	private void RightDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000913")]
	[Cpp2IlInjected.Address(RVA = "0x100C31C", Offset = "0x100C31C", VA = "0x100C31C")]
	private void ActivateLeftController()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0x1008A18", Offset = "0x1008A18", VA = "0x1008A18")]
	public void DrawInventoryPage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x100E688", Offset = "0x100E688", VA = "0x100E688")]
	public void DrawInventoryItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0xFF9E34", Offset = "0xFF9E34", VA = "0xFF9E34")]
	public bool ClickedOutOfRegion(Rectangle popupRegion, bool showDebug = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x100EC70", Offset = "0x100EC70", VA = "0x100EC70")]
	public void DrawLeftMenuButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x100FD38", Offset = "0x100FD38", VA = "0x100FD38")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x10102B0", Offset = "0x10102B0", VA = "0x10102B0")]
	public GUIPageIcons()
	{
	}
}
