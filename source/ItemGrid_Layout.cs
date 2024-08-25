using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001B1")]
[Serializable]
public class ItemGrid_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BBD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B25B0", Offset = "0x9B25B0", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DraggableItemGrid_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ItemGrid_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int ItemCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int ItemLineCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 PickingBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 PickingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 ExtraElementSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000E40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ControlAnchor.ControlId FirstAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 FirstItemLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000E43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 StackCountOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 AmmoCountOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public bool CentreAlign;

	[global::Cpp2ILInjected.Token(Token = "0x4000E46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
	public bool RightAlign;

	[global::Cpp2ILInjected.Token(Token = "0x20001B2")]
	public enum ReorderStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000E48")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000E49")]
		ReverseAllItems,
		[global::Cpp2ILInjected.Token(Token = "0x4000E4A")]
		ReverseLine,
		[global::Cpp2ILInjected.Token(Token = "0x4000E4B")]
		ReverseColumns,
		[global::Cpp2ILInjected.Token(Token = "0x4000E4C")]
		SwapColumns
	}
}
