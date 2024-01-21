using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000139")]
public class ProgressBar_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000AA7")]
	public Texture_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000AA8")]
	public float BackingScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000AA9")]
	private bool Vertical;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000AAA")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000AAB")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000AAC")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000AAD")]
	public Vector2 FillingSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000AAE")]
	public Vector2 FillingLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000AAF")]
	public Color FillingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000AB0")]
	public Color FillingColorEmpty;

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x10BCAD4", Offset = "0x10BCAD4", VA = "0x10BCAD4")]
	public ProgressBar_Layout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x10BCCEC", Offset = "0x10BCCEC", VA = "0x10BCCEC")]
	public ProgressBar_Layout(string backingTexture)
	{
	}
}
