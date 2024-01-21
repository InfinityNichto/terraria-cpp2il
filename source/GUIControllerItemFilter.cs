using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000097")]
public class GUIControllerItemFilter : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private int selectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private int selectedColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private bool selectedSearch;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xF69F44", Offset = "0xF69F44", VA = "0xF69F44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0xF69E8C", Offset = "0xF69E8C", VA = "0xF69E8C")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xF69EE4", Offset = "0xF69EE4", VA = "0xF69EE4")]
	private int GetInfoCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xF69EEC", Offset = "0xF69EEC", VA = "0xF69EEC")]
	private float GetInfoItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0xF6A07C", Offset = "0xF6A07C", VA = "0xF6A07C")]
	public GUIControllerItemFilter(GUIPageIcons.Category cat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xF6A084", Offset = "0xF6A084", VA = "0xF6A084", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xF6A0A0", Offset = "0xF6A0A0", VA = "0xF6A0A0")]
	public void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xF6A0A4", Offset = "0xF6A0A4", VA = "0xF6A0A4", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0xF6A0E0", Offset = "0xF6A0E0", VA = "0xF6A0E0", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
