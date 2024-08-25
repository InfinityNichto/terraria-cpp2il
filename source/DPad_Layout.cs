using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001AE")]
[Serializable]
public class DPad_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BBA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B23A0", Offset = "0x9B23A0", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DPad_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000E1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000E1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 CentreLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000E20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4000E21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector2 LeftOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 RightOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 TopOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 BottomOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000E25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color Color;

	[global::Cpp2ILInjected.Token(Token = "0x4000E26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 PickSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000E27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 DeadZone;
}
