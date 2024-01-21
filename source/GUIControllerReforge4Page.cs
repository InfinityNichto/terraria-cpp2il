using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200009E")]
public class GUIControllerReforge4Page : GUIControllerReforge
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1219194", Offset = "0x1219194", VA = "0x1219194")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x1218F98", Offset = "0x1218F98", VA = "0x1218F98")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x1218FF4", Offset = "0x1218FF4", VA = "0x1218FF4")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x1219058", Offset = "0x1219058", VA = "0x1219058")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x12190B0", Offset = "0x12190B0", VA = "0x12190B0")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x1219110", Offset = "0x1219110", VA = "0x1219110")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x121917C", Offset = "0x121917C", VA = "0x121917C", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x1219398", Offset = "0x1219398", VA = "0x1219398")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x12193A0", Offset = "0x12193A0", VA = "0x12193A0")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x12193A8", Offset = "0x12193A8", VA = "0x12193A8", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x12193C4", Offset = "0x12193C4", VA = "0x12193C4", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x12193EC", Offset = "0x12193EC", VA = "0x12193EC", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x1219424", Offset = "0x1219424", VA = "0x1219424", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x121945C", Offset = "0x121945C", VA = "0x121945C", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x1217FD8", Offset = "0x1217FD8", VA = "0x1217FD8")]
	public GUIControllerReforge4Page()
	{
	}
}
