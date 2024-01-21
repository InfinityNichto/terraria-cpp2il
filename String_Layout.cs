using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200013F")]
public class String_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D8")]
	public enum FontType
	{
		[Cpp2IlInjected.Token(Token = "0x4007BA5")]
		MouseText,
		[Cpp2IlInjected.Token(Token = "0x4007BA6")]
		DeathText
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000AFB")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000AFC")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000AFD")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000AFE")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000AFF")]
	public LayoutCalculator.AnchorType Alignment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000B00")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000B01")]
	public FontType RenderFont;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000B02")]
	public bool MultiLineUseAlignment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000B03")]
	public float WrapWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000B04")]
	public int MaxLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000B05")]
	public float MultilineScale;

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x1063E80", Offset = "0x1063E80", VA = "0x1063E80")]
	public void Copy(String_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x1063EE4", Offset = "0x1063EE4", VA = "0x1063EE4")]
	public SpriteFont GetFont()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x1063FA0", Offset = "0x1063FA0", VA = "0x1063FA0")]
	public String_Layout()
	{
	}
}
