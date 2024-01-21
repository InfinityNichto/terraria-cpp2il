using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[JsonObject]
public class GUIPageIconGrouping
{
	[Cpp2IlInjected.Token(Token = "0x20007C2")]
	public enum SettingCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4007A3E")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007A3F")]
		JM,
		[Cpp2IlInjected.Token(Token = "0x4007A40")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4007A41")]
		InfoAccessories,
		[Cpp2IlInjected.Token(Token = "0x4007A42")]
		Bestiary,
		[Cpp2IlInjected.Token(Token = "0x4007A43")]
		Map,
		[Cpp2IlInjected.Token(Token = "0x4007A44")]
		HousingMenu,
		[Cpp2IlInjected.Token(Token = "0x4007A45")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x4007A46")]
		Emotes,
		[Cpp2IlInjected.Token(Token = "0x4007A47")]
		None
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	[JsonProperty]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	[JsonProperty]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	[JsonProperty]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	[JsonProperty]
	public List<GUIPageIcons.Category> AllowedCategories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	[JsonProperty]
	public List<SettingCategory> SettingEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private List<SettingCategory> _settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private GUIControllerPageGroup _menuController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private List<GUIPageIcons.Category> _options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private GUIPageIcons.Category _selectedCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	[JsonProperty]
	public bool _lastSelectedSet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	[JsonProperty]
	public GUIPageIcons.Category _lastSelectedCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	private GUIPageIcons.Category _preHousingCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	public bool ignoreClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	public bool ignoreShutdown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private GUIPageIcons.Category HoverCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private Vector2 pageButtonRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	private bool drawEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private Comparison<GUIPageIcons.Category> Sorter;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool LeftSideGrouping
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x10049B4", Offset = "0x10049B4", VA = "0x10049B4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public List<SettingCategory> SettingList
	{
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x10049C8", Offset = "0x10049C8", VA = "0x10049C8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GUIControllerPageGroup MenuController
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x10005A8", Offset = "0x10005A8", VA = "0x10005A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public List<GUIPageIcons.Category> Options
	{
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x1004C00", Offset = "0x1004C00", VA = "0x1004C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public GUIPageIcons.Category LastSelectedCategory
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x1004C08", Offset = "0x1004C08", VA = "0x1004C08")]
		get
		{
			return default(GUIPageIcons.Category);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public GUIPageIcons.Category SelectedCategory
	{
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x1003F44", Offset = "0x1003F44", VA = "0x1003F44")]
		get
		{
			return default(GUIPageIcons.Category);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x1004CB0", Offset = "0x1004CB0", VA = "0x1004CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector2 PageButtonSize
	{
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x1005970", Offset = "0x1005970", VA = "0x1005970")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x1000650", Offset = "0x1000650", VA = "0x1000650")]
	public void LoadPageAnchor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x1003AF0", Offset = "0x1003AF0", VA = "0x1003AF0")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x100409C", Offset = "0x100409C", VA = "0x100409C")]
	public Rectangle GetUIScaleRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x10042AC", Offset = "0x10042AC", VA = "0x10042AC")]
	public void LoadSettingAnchor(SettingCategory category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x1004624", Offset = "0x1004624", VA = "0x1004624")]
	public GUIControllerItem GetControllerNavigateController(int row, int column)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x1003818", Offset = "0x1003818", VA = "0x1003818")]
	private void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x10049D0", Offset = "0x10049D0", VA = "0x10049D0")]
	public GUIControllerItem NavigateRight(int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x1004A5C", Offset = "0x1004A5C", VA = "0x1004A5C")]
	public GUIControllerItem NavigateLeft(int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x1004AE8", Offset = "0x1004AE8", VA = "0x1004AE8")]
	public GUIControllerItem NavigateUp(int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x1004B74", Offset = "0x1004B74", VA = "0x1004B74")]
	public GUIControllerItem NavigateDown(int row)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x1005984", Offset = "0x1005984", VA = "0x1005984")]
	public static GUIPageIcons.Category GetCategoryFromActiveController()
	{
		return default(GUIPageIcons.Category);
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x10059F0", Offset = "0x10059F0", VA = "0x10059F0")]
	public void ActivateController(bool pageContent = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x1004458", Offset = "0x1004458", VA = "0x1004458")]
	private void LoadColourState(bool pageContent = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x1005EC0", Offset = "0x1005EC0", VA = "0x1005EC0")]
	public void DrawClosed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x10061D8", Offset = "0x10061D8", VA = "0x10061D8")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x10068F4", Offset = "0x10068F4", VA = "0x10068F4")]
	public void DrawEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x1006B5C", Offset = "0x1006B5C", VA = "0x1006B5C")]
	public GUIControllerItem NavigateFromMenuIntoPage(int MenuRow)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x1006C40", Offset = "0x1006C40", VA = "0x1006C40")]
	private float PageScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x1004008", Offset = "0x1004008", VA = "0x1004008")]
	public static bool CanCollapse(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x1006C48", Offset = "0x1006C48", VA = "0x1006C48")]
	private void PageOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x1007EE8", Offset = "0x1007EE8", VA = "0x1007EE8")]
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x100852C", Offset = "0x100852C", VA = "0x100852C")]
	private string GetPageString(GUIPageIcons.Category category)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x1006024", Offset = "0x1006024", VA = "0x1006024")]
	private void DrawPageIcons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x10063AC", Offset = "0x10063AC", VA = "0x10063AC")]
	private void DrawPageContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x1005364", Offset = "0x1005364", VA = "0x1005364")]
	public static bool InteractionCategory(GUIPageIcons.Category cat)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x1008ADC", Offset = "0x1008ADC", VA = "0x1008ADC")]
	private int SortCategory(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x1008C24", Offset = "0x1008C24", VA = "0x1008C24")]
	public void SortOptionsAndRefresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x1008DE4", Offset = "0x1008DE4", VA = "0x1008DE4")]
	public void DrawOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x1009A70", Offset = "0x1009A70", VA = "0x1009A70")]
	private void LoadTransactionButtonColour(TransactionButton_Layout layout, Color Normal, Color Pressed, Color Disabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x1009A84", Offset = "0x1009A84", VA = "0x1009A84")]
	public void DrawEditOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x100A364", Offset = "0x100A364", VA = "0x100A364")]
	public GUIPageIconGrouping()
	{
	}
}
