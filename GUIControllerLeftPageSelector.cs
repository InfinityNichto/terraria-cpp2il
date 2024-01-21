using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000098")]
public class GUIControllerLeftPageSelector : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private int selectedIndex;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xF6AA5C", Offset = "0xF6AA5C", VA = "0xF6AA5C", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xF6AADC", Offset = "0xF6AADC", VA = "0xF6AADC")]
	public int GetSelectedItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0xF6AAE4", Offset = "0xF6AAE4", VA = "0xF6AAE4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0xF6AAEC", Offset = "0xF6AAEC", VA = "0xF6AAEC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABF0", Offset = "0xF6ABF0", VA = "0xF6ABF0", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xF6AE98", Offset = "0xF6AE98", VA = "0xF6AE98")]
	public GUIControllerLeftPageSelector()
	{
	}
}
