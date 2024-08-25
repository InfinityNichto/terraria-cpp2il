using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000254")]
public class WorldOperationProgress_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D56")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D74B8", Offset = "0x9D74B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D57")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7504", Offset = "0x9D7504", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldOperationProgress_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40018A0")]
	public static WorldOperationProgress_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40018A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x40018A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
	public bool FullHMStatus;

	[global::Cpp2ILInjected.Token(Token = "0x40018A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40018A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Button_Layout ProgressIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40018A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve HMIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x40018A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public AnimationCurve HMIconAlpha;

	[global::Cpp2ILInjected.Token(Token = "0x40018A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout HMConversionIcon;
}
