using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020E")]
public class QuitConfirm_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFCB0", Offset = "0x9CFCB0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CBB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFCFC", Offset = "0x9CFCFC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public QuitConfirm_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001397")]
	public static QuitConfirm_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001398")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001399")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400139A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400139B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x400139C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Quit;

	[global::Cpp2ILInjected.Token(Token = "0x400139D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Back;
}
