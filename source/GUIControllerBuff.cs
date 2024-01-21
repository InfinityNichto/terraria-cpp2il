using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GUIControllerBuff : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private int selectedItem;

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xF8F334", Offset = "0xF8F334", VA = "0xF8F334", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xF8F340", Offset = "0xF8F340", VA = "0xF8F340", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xF8F348", Offset = "0xF8F348", VA = "0xF8F348")]
	private void Clamp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xF8F43C", Offset = "0xF8F43C", VA = "0xF8F43C")]
	public void NavigateNext()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xF8F4C8", Offset = "0xF8F4C8", VA = "0xF8F4C8")]
	public void NavigatePrevious()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xF8F558", Offset = "0xF8F558", VA = "0xF8F558", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xF8F590", Offset = "0xF8F590", VA = "0xF8F590")]
	public int GetSelectedItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xF8F598", Offset = "0xF8F598", VA = "0xF8F598", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xF8F850", Offset = "0xF8F850", VA = "0xF8F850")]
	public GUIControllerBuff()
	{
	}
}
