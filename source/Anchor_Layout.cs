using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200012D")]
public class Anchor_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A32")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A33")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A34")]
	public Vector2 Location;

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x11FD2D0", Offset = "0x11FD2D0", VA = "0x11FD2D0")]
	public Anchor_Layout()
	{
	}
}
