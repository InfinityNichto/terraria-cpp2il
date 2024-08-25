using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001B3")]
[Serializable]
public class Panel_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BBE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2780", Offset = "0x9B2780", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Apply", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Copy", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void Copy(Panel_Layout other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BBF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B2808", Offset = "0x9B2808", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransactionButtonStyle_Definition), Member = "Copy", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public Panel_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x4000E50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Size;

	[global::Cpp2ILInjected.Token(Token = "0x4000E51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AnchorForSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000E52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public ControlAnchor.ControlId SizeAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public LayoutCalculator.AnchorType SizeAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 SizeLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000E55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 PickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000E56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Vector2 PickOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Color BackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color BorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Color HighlightColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000E5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout Border;

	[global::Cpp2ILInjected.Token(Token = "0x4000E5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout CursorHighlight;
}
