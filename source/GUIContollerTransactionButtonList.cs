using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GUIContollerTransactionButtonList : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000783")]
	public delegate void SetupRegions(bool setup);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private bool _vertical;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool _wrapAround;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private int _selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private TransactionButton_Layout[] _items;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private SetupRegions _regionSetup;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xF8C8D8", Offset = "0xF8C8D8", VA = "0xF8C8D8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xF8C940", Offset = "0xF8C940", VA = "0xF8C940")]
	public GUIContollerTransactionButtonList(bool vertical, bool wrapAround, TransactionButton_Layout[] items, [Optional] SetupRegions regionSetup)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xF8C980", Offset = "0xF8C980", VA = "0xF8C980", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xF8C98C", Offset = "0xF8C98C", VA = "0xF8C98C")]
	public void SelectOption(int option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xF8C994", Offset = "0xF8C994", VA = "0xF8C994", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xF8CD54", Offset = "0xF8CD54", VA = "0xF8CD54", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationAxis)
	{
		return null;
	}
}
