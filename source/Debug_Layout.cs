using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001D0")]
public class Debug_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BFE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5D58", Offset = "0x9B5D58", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BFF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5DA4", Offset = "0x9B5DA4", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Debug_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001041")]
	public static Debug_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001042")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public LayoutCalculator.AnchorType DebugAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001043")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 DebugIconLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4001044")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float DebugIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001045")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 DebugIconPickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4001046")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Color DebugIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001047")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001048")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Text;

	[global::Cpp2ILInjected.Token(Token = "0x4001049")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Send;

	[global::Cpp2ILInjected.Token(Token = "0x400104A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;
}
