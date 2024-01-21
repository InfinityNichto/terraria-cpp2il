using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GUIControllerHotbarRadial : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool hotbarMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private int selectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private int selectedColumn;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x129F0B8", Offset = "0x129F0B8", VA = "0x129F0B8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x129F0C0", Offset = "0x129F0C0", VA = "0x129F0C0", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x129F2E0", Offset = "0x129F2E0", VA = "0x129F2E0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x129F604", Offset = "0x129F604", VA = "0x129F604")]
	public int GetSelectedItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x129F6F8", Offset = "0x129F6F8", VA = "0x129F6F8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x129FC5C", Offset = "0x129FC5C", VA = "0x129FC5C")]
	public GUIControllerHotbarRadial()
	{
	}
}
