using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class GUIControllerRightPageSelector : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private int selectedIndex;

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x1219D20", Offset = "0x1219D20", VA = "0x1219D20", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x1219DA0", Offset = "0x1219DA0", VA = "0x1219DA0")]
	public int GetSelectedItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x1219DA8", Offset = "0x1219DA8", VA = "0x1219DA8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x1219DB0", Offset = "0x1219DB0", VA = "0x1219DB0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x1219EB4", Offset = "0x1219EB4", VA = "0x1219EB4", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x1217F94", Offset = "0x1217F94", VA = "0x1217F94")]
	public GUIControllerRightPageSelector()
	{
	}
}
