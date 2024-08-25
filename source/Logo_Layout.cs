using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001FD")]
public class Logo_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF0BC", Offset = "0x9CF0BC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF108", Offset = "0x9CF108", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Logo_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
	public static Logo_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x40012A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x40012A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x40012A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float Scale;
}
