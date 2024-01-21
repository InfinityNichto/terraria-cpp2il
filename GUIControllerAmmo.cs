using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GUIControllerAmmo : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public int itemColmun;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0xF8D5D8", Offset = "0xF8D5D8", VA = "0xF8D5D8")]
	public GUIControllerAmmo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0xF8D5E4", Offset = "0xF8D5E4", VA = "0xF8D5E4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xF8D5E8", Offset = "0xF8D5E8", VA = "0xF8D5E8", Slot = "13")]
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xF8D60C", Offset = "0xF8D60C", VA = "0xF8D60C", Slot = "14")]
	public virtual int GetInventoryRow()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xF8D630", Offset = "0xF8D630", VA = "0xF8D630", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xF8D7DC", Offset = "0xF8D7DC", VA = "0xF8D7DC", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}
}
