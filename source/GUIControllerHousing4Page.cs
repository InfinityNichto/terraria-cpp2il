using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000092")]
public class GUIControllerHousing4Page : GUIControllerHousing
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x12A035C", Offset = "0x12A035C", VA = "0x12A035C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x12A0154", Offset = "0x12A0154", VA = "0x12A0154")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x12A01B0", Offset = "0x12A01B0", VA = "0x12A01B0")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x12A0214", Offset = "0x12A0214", VA = "0x12A0214")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x12A026C", Offset = "0x12A026C", VA = "0x12A026C")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x12A02CC", Offset = "0x12A02CC", VA = "0x12A02CC")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x12A0338", Offset = "0x12A0338", VA = "0x12A0338", Slot = "14")]
	public override void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x12A0574", Offset = "0x12A0574", VA = "0x12A0574", Slot = "15")]
	public override void PreviousItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x12A0598", Offset = "0x12A0598", VA = "0x12A0598", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x12A05BC", Offset = "0x12A05BC", VA = "0x12A05BC")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x12A05C4", Offset = "0x12A05C4", VA = "0x12A05C4")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x12A05CC", Offset = "0x12A05CC", VA = "0x12A05CC", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x12A05E0", Offset = "0x12A05E0", VA = "0x12A05E0", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x12A05F8", Offset = "0x12A05F8", VA = "0x12A05F8", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x12A062C", Offset = "0x12A062C", VA = "0x12A062C", Slot = "16")]
	protected override void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x12A0630", Offset = "0x12A0630", VA = "0x12A0630", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x12A0664", Offset = "0x12A0664", VA = "0x12A0664", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x12A0698", Offset = "0x12A0698", VA = "0x12A0698")]
	public GUIControllerHousing4Page()
	{
	}
}
