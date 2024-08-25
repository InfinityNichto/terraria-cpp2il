using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
public class ControlsStatusIndicators_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BF2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5520", Offset = "0x9B5520", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B556C", Offset = "0x9B556C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControlsStatusIndicators_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000FB5")]
	public static ControlsStatusIndicators_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000FB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000FB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000FB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout AimMode;

	[global::Cpp2ILInjected.Token(Token = "0x4000FB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout TargetMode;

	[global::Cpp2ILInjected.Token(Token = "0x4000FBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ControlsProfile;
}
