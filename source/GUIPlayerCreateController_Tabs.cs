using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GUIPlayerCreateController_Tabs : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public GUIPlayerCreateMenu.ItemSelection HighlightedTab;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x1141384", Offset = "0x1141384", VA = "0x1141384")]
	public GUIPlayerCreateController_Tabs(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x11419D8", Offset = "0x11419D8", VA = "0x11419D8", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x1142F10", Offset = "0x1142F10", VA = "0x1142F10", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x1141450", Offset = "0x1141450", VA = "0x1141450")]
	public GUIControllerItem NavigateIntoCurrentPage(bool fromTabSwitch = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x1142F18", Offset = "0x1142F18", VA = "0x1142F18", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x1142F70", Offset = "0x1142F70", VA = "0x1142F70", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
