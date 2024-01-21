using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class GUIControllerStaticGridNavigator
{
	[Cpp2IlInjected.Token(Token = "0x200079C")]
	public delegate ItemGrid_Layout GetGrid();

	[Cpp2IlInjected.Token(Token = "0x200079D")]
	public delegate int GetCollectionCount();

	[Cpp2IlInjected.Token(Token = "0x200079E")]
	public delegate float GetItemScale();

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly GetGrid _grid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private readonly GetItemScale _itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly GUIPageContentController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private readonly GetCollectionCount _displayItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private readonly GetCollectionCount _menuItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public int menuRow;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private ItemGrid_Layout GridLayout
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x121D810", Offset = "0x121D810", VA = "0x121D810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private float itemScale
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x121DA58", Offset = "0x121DA58", VA = "0x121DA58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private int MenuItemCount
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x121DCB0", Offset = "0x121DCB0", VA = "0x121DCB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private int DisplayItemCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x121DEF8", Offset = "0x121DEF8", VA = "0x121DEF8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private int MenuColumn
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x121DF80", Offset = "0x121DF80", VA = "0x121DF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private bool LeftSideController
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x121DF40", Offset = "0x121DF40", VA = "0x121DF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private bool HasMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x121DF00", Offset = "0x121DF00", VA = "0x121DF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool InMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x121D0A8", Offset = "0x121D0A8", VA = "0x121D0A8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x121D120", Offset = "0x121D120", VA = "0x121D120")]
	public GUIControllerStaticGridNavigator(GUIPageContentController controller, GetGrid grid, GetItemScale itemScale, GetCollectionCount menuItemCount, GetCollectionCount displayItemCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x121D190", Offset = "0x121D190", VA = "0x121D190")]
	public void Activate(int itemIndex = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x121D26C", Offset = "0x121D26C", VA = "0x121D26C")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x121D214", Offset = "0x121D214", VA = "0x121D214")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x121E158", Offset = "0x121E158", VA = "0x121E158")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x121E1D0", Offset = "0x121E1D0", VA = "0x121E1D0")]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x121E230", Offset = "0x121E230", VA = "0x121E230")]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x121E260", Offset = "0x121E260", VA = "0x121E260")]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x121E290", Offset = "0x121E290", VA = "0x121E290")]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x121DF98", Offset = "0x121DF98", VA = "0x121DF98")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x121E350", Offset = "0x121E350", VA = "0x121E350")]
	protected void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x121D3C4", Offset = "0x121D3C4", VA = "0x121D3C4")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x121D694", Offset = "0x121D694", VA = "0x121D694")]
	public void NavigateInto(int column, int row)
	{
	}
}
