using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000120")]
public class CachedGridLayoutSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400099D")]
	public bool Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400099E")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400099F")]
	public int ItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40009A0")]
	public int ItemLineCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40009A1")]
	public Vector2 PickingBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40009A2")]
	public Vector2 PickingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40009A3")]
	public Vector2 ExtraElementSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40009A4")]
	public ControlAnchor.ControlId FirstAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40009A5")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40009A6")]
	public Vector2 FirstItemLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40009A7")]
	public int ScreenWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40009A8")]
	public int ScreenHeight;

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x1204B38", Offset = "0x1204B38", VA = "0x1204B38")]
	public bool Dirty(ItemGrid_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x1204DE4", Offset = "0x1204DE4", VA = "0x1204DE4")]
	public void Cache(ItemGrid_Layout layout)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x1204EE8", Offset = "0x1204EE8", VA = "0x1204EE8")]
	public CachedGridLayoutSettings()
	{
	}
}
