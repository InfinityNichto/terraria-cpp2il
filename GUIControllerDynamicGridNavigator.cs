using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class GUIControllerDynamicGridNavigator
{
	[Cpp2IlInjected.Token(Token = "0x2000794")]
	public delegate DraggableItemGrid_Layout GetGrid();

	[Cpp2IlInjected.Token(Token = "0x2000795")]
	public delegate int GetCollectionCount();

	[Cpp2IlInjected.Token(Token = "0x2000796")]
	public delegate float GetItemScale();

	[Cpp2IlInjected.Token(Token = "0x2000797")]
	public delegate float GetScrollOffset();

	[Cpp2IlInjected.Token(Token = "0x2000798")]
	public delegate void SetScrollOffset(float scrollOffset);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly GetGrid _grid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private readonly GetCollectionCount _collectionCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly GetItemScale _itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly GetScrollOffset _getScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly SetScrollOffset _setScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly GUIPageContentController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly GetCollectionCount _displayItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly GetCollectionCount _menuItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private bool scrollDisabledUntilChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private int itemCountAtDisableScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public bool inMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public int menuRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private int scrollOffset;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private DraggableItemGrid_Layout GridLayout
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x12962A8", Offset = "0x12962A8", VA = "0x12962A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private int itemCount
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x12964F0", Offset = "0x12964F0", VA = "0x12964F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private float itemScale
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x1296738", Offset = "0x1296738", VA = "0x1296738")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private float GridScrollOffset
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1296990", Offset = "0x1296990", VA = "0x1296990")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x1296BE8", Offset = "0x1296BE8", VA = "0x1296BE8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private int MenuItemCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x12971D8", Offset = "0x12971D8", VA = "0x12971D8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private int DisplayItemCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x12971E0", Offset = "0x12971E0", VA = "0x12971E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private int MaxRow_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1296FEC", Offset = "0x1296FEC", VA = "0x1296FEC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private int MaxRowColumn_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x12970A4", Offset = "0x12970A4", VA = "0x12970A4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private int MaxRow_Vertical
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1297E10", Offset = "0x1297E10", VA = "0x1297E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private int MaxRowColumn_Vertical
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1297E58", Offset = "0x1297E58", VA = "0x1297E58")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private int MenuColumn
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1297EB8", Offset = "0x1297EB8", VA = "0x1297EB8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool LeftSideController
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1296FA4", Offset = "0x1296FA4", VA = "0x1296FA4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private int MaxScrollOffset_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1297F54", Offset = "0x1297F54", VA = "0x1297F54")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private int MaxDisplayRow_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x1298034", Offset = "0x1298034", VA = "0x1298034")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private bool HasMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x1298064", Offset = "0x1298064", VA = "0x1298064")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool InMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x1292354", Offset = "0x1292354", VA = "0x1292354")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x12924D8", Offset = "0x12924D8", VA = "0x12924D8")]
	public GUIControllerDynamicGridNavigator(GUIPageContentController controller, GetGrid grid, GetCollectionCount collectionCount, GetItemScale itemScale, GetScrollOffset getScrollOffset, SetScrollOffset setScrollOffset, GetCollectionCount menuItemCount, GetCollectionCount displayItemCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x1296E88", Offset = "0x1296E88", VA = "0x1296E88")]
	public void DisableScrollUntilChange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x1296EAC", Offset = "0x1296EAC", VA = "0x1296EAC")]
	public void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x1297104", Offset = "0x1297104", VA = "0x1297104")]
	public void PreviousItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x12971E8", Offset = "0x12971E8", VA = "0x12971E8")]
	public bool isSelectedItem(int itemIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x12928D8", Offset = "0x12928D8", VA = "0x12928D8")]
	public void Activate(int itemIndex = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x1292D34", Offset = "0x1292D34", VA = "0x1292D34")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1292AB0", Offset = "0x1292AB0", VA = "0x1292AB0")]
	public void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x1297250", Offset = "0x1297250", VA = "0x1297250")]
	protected void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x12980A4", Offset = "0x12980A4", VA = "0x12980A4")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x129811C", Offset = "0x129811C", VA = "0x129811C")]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x1298174", Offset = "0x1298174", VA = "0x1298174")]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x12981B4", Offset = "0x12981B4", VA = "0x12981B4")]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x12981F4", Offset = "0x12981F4", VA = "0x12981F4")]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x129254C", Offset = "0x129254C", VA = "0x129254C")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x12976C0", Offset = "0x12976C0", VA = "0x12976C0")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x1297A1C", Offset = "0x1297A1C", VA = "0x1297A1C")]
	private GUIControllerItem NavigateVertical(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x12982C0", Offset = "0x12982C0", VA = "0x12982C0")]
	protected void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x1292E44", Offset = "0x1292E44", VA = "0x1292E44")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x12931D0", Offset = "0x12931D0", VA = "0x12931D0")]
	public void NavigateInto(int column, int row)
	{
	}
}
