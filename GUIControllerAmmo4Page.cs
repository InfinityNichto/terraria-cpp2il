using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GUIControllerAmmo4Page : GUIControllerAmmo
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xF8DAA8", Offset = "0xF8DAA8", VA = "0xF8DAA8", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xF8DB50", Offset = "0xF8DB50", VA = "0xF8DB50", Slot = "13")]
	public override void NavigateFromInventoryRow(int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xF8DB60", Offset = "0xF8DB60", VA = "0xF8DB60", Slot = "14")]
	public override int GetInventoryRow()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xF8DB68", Offset = "0xF8DB68", VA = "0xF8DB68", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xF8DDCC", Offset = "0xF8DDCC", VA = "0xF8DDCC", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xF8E1BC", Offset = "0xF8E1BC", VA = "0xF8E1BC")]
	public GUIControllerAmmo4Page()
	{
	}
}
