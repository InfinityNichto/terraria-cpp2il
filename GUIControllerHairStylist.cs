using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200008E")]
public class GUIControllerHairStylist : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x2000792")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x4007957")]
		Style,
		[Cpp2IlInjected.Token(Token = "0x4007958")]
		Colour,
		[Cpp2IlInjected.Token(Token = "0x4007959")]
		Element,
		[Cpp2IlInjected.Token(Token = "0x400795A")]
		Back,
		[Cpp2IlInjected.Token(Token = "0x400795B")]
		Buy
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public Controls selectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public int itemRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public int itemColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public int scrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public int itemSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public int maxRowIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public int maxRowColumn;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1299E2C", Offset = "0x1299E2C", VA = "0x1299E2C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1299E34", Offset = "0x1299E34", VA = "0x1299E34", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x129A01C", Offset = "0x129A01C", VA = "0x129A01C")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x129A294", Offset = "0x129A294", VA = "0x129A294", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x129A528", Offset = "0x129A528", VA = "0x129A528")]
	private void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x129A52C", Offset = "0x129A52C", VA = "0x129A52C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x129A948", Offset = "0x129A948", VA = "0x129A948")]
	public GUIControllerHairStylist()
	{
	}
}
