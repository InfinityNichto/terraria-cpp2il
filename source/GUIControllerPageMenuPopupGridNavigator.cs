using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class GUIControllerPageMenuPopupGridNavigator
{
	[Cpp2IlInjected.Token(Token = "0x2000799")]
	public delegate ItemGrid_Layout GetGrid();

	[Cpp2IlInjected.Token(Token = "0x200079A")]
	public delegate int GetCollectionCount();

	[Cpp2IlInjected.Token(Token = "0x200079B")]
	public delegate float GetItemScale();

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private readonly GetGrid _grid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private readonly GetCollectionCount _collectionCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private readonly GetItemScale _itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private readonly GUIPageContentController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private ItemGrid_Layout GridLayout
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1216080", Offset = "0x1216080", VA = "0x1216080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private int itemCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x12162C8", Offset = "0x12162C8", VA = "0x12162C8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private float itemScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1216510", Offset = "0x1216510", VA = "0x1216510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private int MaxRow_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1216914", Offset = "0x1216914", VA = "0x1216914")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private int MaxRowColumn_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x12169CC", Offset = "0x12169CC", VA = "0x12169CC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private bool LeftSideController
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x1216768", Offset = "0x1216768", VA = "0x1216768")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private int MaxScrollOffset_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x1216A14", Offset = "0x1216A14", VA = "0x1216A14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private int MaxDisplayRow_Horizontal
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1216AF4", Offset = "0x1216AF4", VA = "0x1216AF4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x12153DC", Offset = "0x12153DC", VA = "0x12153DC")]
	public GUIControllerPageMenuPopupGridNavigator(GUIPageContentController controller, GetGrid grid, GetCollectionCount collectionCount, GetItemScale itemScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x12154D4", Offset = "0x12154D4", VA = "0x12154D4")]
	public void Activate(int itemIndex = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x1215718", Offset = "0x1215718", VA = "0x1215718")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x1216788", Offset = "0x1216788", VA = "0x1216788")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x1216B24", Offset = "0x1216B24", VA = "0x1216B24")]
	protected void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x121594C", Offset = "0x121594C", VA = "0x121594C")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
