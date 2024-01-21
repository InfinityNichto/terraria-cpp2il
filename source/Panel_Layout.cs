using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000137")]
public class Panel_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A90")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A91")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A92")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A93")]
	public Vector2 Size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A94")]
	public bool AnchorForSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A95")]
	public ControlAnchor.ControlId SizeAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A96")]
	public LayoutCalculator.AnchorType SizeAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A97")]
	public Vector2 SizeLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000A98")]
	public Vector2 PickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000A99")]
	public Vector2 PickOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000A9A")]
	public Color BackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000A9B")]
	public Color BorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000A9C")]
	public Color HighlightColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000A9D")]
	public Texture_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000A9E")]
	public Texture_Layout Border;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000A9F")]
	public Texture_Layout CursorHighlight;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x10B33E8", Offset = "0x10B33E8", VA = "0x10B33E8")]
	public void Copy(Panel_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x10B34BC", Offset = "0x10B34BC", VA = "0x10B34BC")]
	public Panel_Layout()
	{
	}
}
