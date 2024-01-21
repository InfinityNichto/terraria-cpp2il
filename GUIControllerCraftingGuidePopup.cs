using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GUIControllerCraftingGuidePopup : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000790")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x4007949")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x400794A")]
		Back
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1293A4C", Offset = "0x1293A4C", VA = "0x1293A4C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x12937B0", Offset = "0x12937B0", VA = "0x12937B0")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1293838", Offset = "0x1293838", VA = "0x1293838")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x12938B0", Offset = "0x12938B0", VA = "0x12938B0")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1293938", Offset = "0x1293938", VA = "0x1293938")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x12939A8", Offset = "0x12939A8", VA = "0x12939A8")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x1293A28", Offset = "0x1293A28", VA = "0x1293A28")]
	public bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1293C68", Offset = "0x1293C68", VA = "0x1293C68")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1293C70", Offset = "0x1293C70", VA = "0x1293C70")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x1293C78", Offset = "0x1293C78", VA = "0x1293C78", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x1293CEC", Offset = "0x1293CEC", VA = "0x1293CEC", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x1293D04", Offset = "0x1293D04", VA = "0x1293D04")]
	public void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x1293D78", Offset = "0x1293D78", VA = "0x1293D78")]
	protected void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x1293D7C", Offset = "0x1293D7C", VA = "0x1293D7C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1293ED0", Offset = "0x1293ED0", VA = "0x1293ED0")]
	protected void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1293ED4", Offset = "0x1293ED4", VA = "0x1293ED4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x1294058", Offset = "0x1294058", VA = "0x1294058")]
	public void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x12940DC", Offset = "0x12940DC", VA = "0x12940DC")]
	public GUIControllerCraftingGuidePopup()
	{
	}
}
