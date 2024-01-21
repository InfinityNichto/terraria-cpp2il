using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GUIControllerChest : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x128FF08", Offset = "0x128FF08", VA = "0x128FF08")]
	public GUIControllerChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x128FF24", Offset = "0x128FF24", VA = "0x128FF24", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x128FF28", Offset = "0x128FF28", VA = "0x128FF28", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x128FF30", Offset = "0x128FF30", VA = "0x128FF30", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1290038", Offset = "0x1290038", VA = "0x1290038", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
