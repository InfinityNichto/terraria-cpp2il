using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F6")]
public class DeleteWorld_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C8C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CECE0", Offset = "0x9CECE0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CED2C", Offset = "0x9CED2C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DeleteWorld_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001243")]
	public static DeleteWorld_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001244")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001245")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001246")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001247")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	[global::Cpp2ILInjected.Token(Token = "0x4001248")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	[global::Cpp2ILInjected.Token(Token = "0x4001249")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
