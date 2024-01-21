using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class GUIControllerShop : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x1217F9C", Offset = "0x1217F9C", VA = "0x1217F9C")]
	public GUIControllerShop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x121CA8C", Offset = "0x121CA8C", VA = "0x121CA8C", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x121CB10", Offset = "0x121CB10", VA = "0x121CB10", Slot = "13")]
	public virtual bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x121CB18", Offset = "0x121CB18", VA = "0x121CB18", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x121CBEC", Offset = "0x121CBEC", VA = "0x121CBEC", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
