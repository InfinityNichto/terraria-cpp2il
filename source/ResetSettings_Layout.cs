using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020F")]
public class ResetSettings_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CBC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFD54", Offset = "0x9CFD54", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFDA0", Offset = "0x9CFDA0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ResetSettings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400139E")]
	public static ResetSettings_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400139F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40013A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40013A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40013A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	[global::Cpp2ILInjected.Token(Token = "0x40013A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	[global::Cpp2ILInjected.Token(Token = "0x40013A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
