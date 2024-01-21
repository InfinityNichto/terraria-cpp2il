using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class Button_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A5C")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A5D")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A5E")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A5F")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3864B0", Offset = "0x3864B0")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A60")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3864FC", Offset = "0x3864FC")]
	public Vector2 PickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A61")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x38655C", Offset = "0x38655C")]
	public Vector2 PickOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A62")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3865A8", Offset = "0x3865A8")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000A63")]
	[Cpp2IlInjected.Attribute(Name = "BoxGroupAttribute", RVA = "0x3865F4", Offset = "0x3865F4")]
	public bool UseCirclePickingRegion;

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x1201F08", Offset = "0x1201F08", VA = "0x1201F08")]
	public Button_Layout()
	{
	}
}
