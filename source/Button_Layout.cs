using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

[global::Cpp2ILInjected.Token(Token = "0x20001AB")]
[Serializable]
public class Button_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B7B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AF554", Offset = "0x9AF554", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QuickActionButton_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Button_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000DED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000DEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000DF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float Scale;

	[BoxGroup("Picking", -1, "Style", null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000DF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector2 PickBorder;

	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000DF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 PickOffset;

	[BoxGroup("Normal", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000DF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Color Color;

	[BoxGroup("Picking", -1, null, null)]
	[global::Cpp2ILInjected.Token(Token = "0x4000DF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool UseCirclePickingRegion;
}
