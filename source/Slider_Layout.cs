using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200013C")]
public class Slider_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000AC4")]
	public Texture_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000AC5")]
	public Color BackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000AC6")]
	public Texture_Layout Notch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000AC7")]
	public Color NotchColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000AC8")]
	public Texture_Layout BackingHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000AC9")]
	public Color BackingHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000ACA")]
	public Texture_Layout NotchHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000ACB")]
	public Color NotchHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000ACC")]
	public float SliderEndCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000ACD")]
	public float BackingScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000ACE")]
	public float NotchScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000ACF")]
	public Vector2 PickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000AD0")]
	public bool Vertical;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000AD1")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000AD2")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000AD3")]
	public Vector2 Location;

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x10615EC", Offset = "0x10615EC", VA = "0x10615EC")]
	public Slider_Layout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x1061788", Offset = "0x1061788", VA = "0x1061788")]
	public Slider_Layout(string backingTexture, string notchTexture)
	{
	}
}
