using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GUIControllerCrafting4Page : GUIControllerCrafting
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x129213C", Offset = "0x129213C", VA = "0x129213C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1291F34", Offset = "0x1291F34", VA = "0x1291F34")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1291F90", Offset = "0x1291F90", VA = "0x1291F90")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1291FF4", Offset = "0x1291FF4", VA = "0x1291FF4")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x129204C", Offset = "0x129204C", VA = "0x129204C")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x12920AC", Offset = "0x12920AC", VA = "0x12920AC")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1292118", Offset = "0x1292118", VA = "0x1292118", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1292374", Offset = "0x1292374", VA = "0x1292374")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x129246C", Offset = "0x129246C", VA = "0x129246C")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1292528", Offset = "0x1292528", VA = "0x1292528", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x12928C0", Offset = "0x12928C0", VA = "0x12928C0", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1292A8C", Offset = "0x1292A8C", VA = "0x1292A8C", Slot = "14")]
	public override void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1292CFC", Offset = "0x1292CFC", VA = "0x1292CFC", Slot = "15")]
	protected override void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1292D00", Offset = "0x1292D00", VA = "0x1292D00", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1292E0C", Offset = "0x1292E0C", VA = "0x1292E0C", Slot = "16")]
	protected override void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x1292E10", Offset = "0x1292E10", VA = "0x1292E10", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x129319C", Offset = "0x129319C", VA = "0x129319C", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x1293258", Offset = "0x1293258", VA = "0x1293258")]
	public GUIControllerCrafting4Page()
	{
	}
}
