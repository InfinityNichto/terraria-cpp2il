using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200013E")]
public class StringButton_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D7")]
	public enum FontType
	{
		[Cpp2IlInjected.Token(Token = "0x4007BA2")]
		MouseText,
		[Cpp2IlInjected.Token(Token = "0x4007BA3")]
		DeathText
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000ADC")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000ADD")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000ADE")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000ADF")]
	public Vector2 Size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000AE0")]
	public Vector2 PickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000AE1")]
	public Vector2 PickOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000AE2")]
	public int TextInset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000AE3")]
	public Color BackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000AE4")]
	public Color DisabledBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000AE5")]
	public Color PressedBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000AE6")]
	public Color BorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000AE7")]
	public Color DisabledBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000AE8")]
	public Color PressedBorderColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000AE9")]
	public Color TextColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000AEA")]
	public Color DisabledTextColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000AEB")]
	public Color PressedTextColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000AEC")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000AED")]
	public float DisabledScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000AEE")]
	public float PressedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000AEF")]
	public float ScaleSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000AF0")]
	public Texture_Layout BackingDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000AF1")]
	public Texture_Layout BorderDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000AF2")]
	public Texture_Layout BackingNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000AF3")]
	public Texture_Layout BorderNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000AF4")]
	public Texture_Layout BackingPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000AF5")]
	public Texture_Layout BorderPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000AF6")]
	public Texture_Layout BackingHighlightPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000AF7")]
	public Vector2 HighlightSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000AF8")]
	public Color HighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000AF9")]
	public Texture_Layout OverBackingHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000AFA")]
	public FontType RenderFont;

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x1063A40", Offset = "0x1063A40", VA = "0x1063A40")]
	public SpriteFont GetFont()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x1063B00", Offset = "0x1063B00", VA = "0x1063B00")]
	public StringButton_Layout()
	{
	}
}
