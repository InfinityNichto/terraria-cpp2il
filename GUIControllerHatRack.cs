using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200008F")]
public class GUIControllerHatRack : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public int itemColumn;

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x129E8C4", Offset = "0x129E8C4", VA = "0x129E8C4")]
	public GUIControllerHatRack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D0", Offset = "0x129E8D0", VA = "0x129E8D0", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D4", Offset = "0x129E8D4", VA = "0x129E8D4", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x129E8D8", Offset = "0x129E8D8", VA = "0x129E8D8", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x129E9CC", Offset = "0x129E9CC", VA = "0x129E9CC", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
