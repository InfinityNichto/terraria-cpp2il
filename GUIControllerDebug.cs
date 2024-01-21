using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GUIControllerDebug : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private int _selected;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1294954", Offset = "0x1294954", VA = "0x1294954", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1294958", Offset = "0x1294958", VA = "0x1294958", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1294960", Offset = "0x1294960", VA = "0x1294960", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x12949EC", Offset = "0x12949EC", VA = "0x12949EC", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1294AC8", Offset = "0x1294AC8", VA = "0x1294AC8")]
	public GUIControllerDebug()
	{
	}
}
