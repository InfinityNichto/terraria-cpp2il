using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000136")]
public class ItemGrid_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D4")]
	public enum ReorderStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4007B78")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007B79")]
		ReverseAllItems,
		[Cpp2IlInjected.Token(Token = "0x4007B7A")]
		ReverseLine,
		[Cpp2IlInjected.Token(Token = "0x4007B7B")]
		ReverseColumns,
		[Cpp2IlInjected.Token(Token = "0x4007B7C")]
		SwapColumns
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A82")]
	public bool Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A83")]
	public ReorderStyle Reorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A84")]
	public int ItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A85")]
	public int ItemLineCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A86")]
	public Vector2 PickingBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A87")]
	public Vector2 PickingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A88")]
	public Vector2 ExtraElementSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000A89")]
	public ControlAnchor.ControlId FirstAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000A8A")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000A8B")]
	public Vector2 FirstItemLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000A8C")]
	public Vector2 StackCountOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000A8D")]
	public Vector2 AmmoCountOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000A8E")]
	public bool CentreAlign;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000A8F")]
	public bool RightAlign;

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x1178A00", Offset = "0x1178A00", VA = "0x1178A00")]
	public ItemGrid_Layout()
	{
	}
}
