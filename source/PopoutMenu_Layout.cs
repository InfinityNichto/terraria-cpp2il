using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001B4")]
[Serializable]
public class PopoutMenu_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BC0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B29F8", Offset = "0x9B29F8", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PopoutMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public QuickActionButton_Layout MenuButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000E5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public PopoutMenu_Layout.ReorderStyle Reorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000E5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout ElementLayout;

	[global::Cpp2ILInjected.Token(Token = "0x4000E60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ElementSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000E61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 BackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 BackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color BackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x20001B5")]
	public enum ReorderStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000E65")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000E66")]
		Reverse
	}
}
