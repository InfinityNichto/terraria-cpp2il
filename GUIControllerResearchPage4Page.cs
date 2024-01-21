using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class GUIControllerResearchPage4Page : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x1219810", Offset = "0x1219810", VA = "0x1219810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x1217FE4", Offset = "0x1217FE4", VA = "0x1217FE4")]
	public GUIControllerResearchPage4Page()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1219614", Offset = "0x1219614", VA = "0x1219614")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x1219670", Offset = "0x1219670", VA = "0x1219670")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x12196D4", Offset = "0x12196D4", VA = "0x12196D4")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x121972C", Offset = "0x121972C", VA = "0x121972C")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x121978C", Offset = "0x121978C", VA = "0x121978C")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x12197F8", Offset = "0x12197F8", VA = "0x12197F8")]
	public bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1219A14", Offset = "0x1219A14", VA = "0x1219A14")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1219A1C", Offset = "0x1219A1C", VA = "0x1219A1C")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1219A24", Offset = "0x1219A24", VA = "0x1219A24", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1219A40", Offset = "0x1219A40", VA = "0x1219A40", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1219ACC", Offset = "0x1219ACC", VA = "0x1219ACC", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1219B90", Offset = "0x1219B90", VA = "0x1219B90", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1219CF8", Offset = "0x1219CF8", VA = "0x1219CF8", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}
}
