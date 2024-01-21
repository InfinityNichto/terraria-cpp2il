using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class GUIPlayerCreateController_MainButtons : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly GUIPlayerCreateController _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public int element;

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x1141364", Offset = "0x1141364", VA = "0x1141364")]
	public GUIPlayerCreateController_MainButtons(GUIPlayerCreateController controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x1141A48", Offset = "0x1141A48", VA = "0x1141A48", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x1142B68", Offset = "0x1142B68", VA = "0x1142B68", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x1142B70", Offset = "0x1142B70", VA = "0x1142B70")]
	public GUIControllerItem NavigateIntoCurrentPage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x1142D80", Offset = "0x1142D80", VA = "0x1142D80", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x1142DD4", Offset = "0x1142DD4", VA = "0x1142DD4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
