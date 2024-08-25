using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F4")]
public class DeleteDedicatedServer_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C88")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEB98", Offset = "0x9CEB98", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C89")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEBE4", Offset = "0x9CEBE4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DeleteDedicatedServer_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001235")]
	public static DeleteDedicatedServer_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001236")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001237")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001238")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001239")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	[global::Cpp2ILInjected.Token(Token = "0x400123A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	[global::Cpp2ILInjected.Token(Token = "0x400123B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
