using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000082")]
public class GUIControllerCoins : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public int itemRow;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x12907D8", Offset = "0x12907D8", VA = "0x12907D8")]
	public GUIControllerCoins()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x12907E4", Offset = "0x12907E4", VA = "0x12907E4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x12907E8", Offset = "0x12907E8", VA = "0x12907E8", Slot = "13")]
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x1290808", Offset = "0x1290808", VA = "0x1290808", Slot = "14")]
	public virtual int GetInventoryRow()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1290824", Offset = "0x1290824", VA = "0x1290824", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x12909D0", Offset = "0x12909D0", VA = "0x12909D0", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
