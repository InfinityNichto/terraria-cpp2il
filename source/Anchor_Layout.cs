using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001A7")]
[Serializable]
public class Anchor_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE900", Offset = "0x9AE900", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Anchor_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 Location;
}
