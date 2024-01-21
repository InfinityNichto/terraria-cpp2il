using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GUIControllerInterfaceEdit : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public int EditControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private int EditProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private int EditTemplate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public int AdjustColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public int AdjustRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public int PageColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public int PageRow;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x12A0904", Offset = "0x12A0904", VA = "0x12A0904", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x12A0910", Offset = "0x12A0910", VA = "0x12A0910", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x12A0918", Offset = "0x12A0918", VA = "0x12A0918")]
	public void UpdatePageScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x12A0B04", Offset = "0x12A0B04", VA = "0x12A0B04", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x12A113C", Offset = "0x12A113C", VA = "0x12A113C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x12A1768", Offset = "0x12A1768", VA = "0x12A1768")]
	public GUIControllerInterfaceEdit()
	{
	}
}
