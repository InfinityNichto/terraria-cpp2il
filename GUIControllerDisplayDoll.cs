using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GUIControllerDisplayDoll : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x129523C", Offset = "0x129523C", VA = "0x129523C")]
	public GUIControllerDisplayDoll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1295248", Offset = "0x1295248", VA = "0x1295248", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x129524C", Offset = "0x129524C", VA = "0x129524C", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x1295250", Offset = "0x1295250", VA = "0x1295250", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x1295374", Offset = "0x1295374", VA = "0x1295374", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
