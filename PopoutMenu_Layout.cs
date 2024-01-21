using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000138")]
public class PopoutMenu_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D5")]
	public enum ReorderStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4007B7E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007B7F")]
		Reverse
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000AA0")]
	public QuickActionButton_Layout MenuButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000AA1")]
	public ReorderStyle Reorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000AA2")]
	public String_Layout ElementLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000AA3")]
	public float ElementSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000AA4")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000AA5")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000AA6")]
	public Color BackingColor;

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x10BC290", Offset = "0x10BC290", VA = "0x10BC290")]
	public PopoutMenu_Layout()
	{
	}
}
