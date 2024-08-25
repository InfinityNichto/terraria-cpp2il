using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000209")]
public class PlayerAndGameModeMismatch_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CB0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF820", Offset = "0x9CF820", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CB1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF86C", Offset = "0x9CF86C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerAndGameModeMismatch_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001327")]
	public static PlayerAndGameModeMismatch_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001328")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001329")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400132A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400132B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x400132C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x400132D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout GameTip;
}
