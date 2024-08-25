using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001A0")]
[Serializable]
public class ControllerMappingEntry_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B6C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACA5C", Offset = "0x9ACA5C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControllerMappingEntry_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000D1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout PulldownButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000D20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout PulldownTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4000D21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout PulldownGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4000D22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Action;

	[global::Cpp2ILInjected.Token(Token = "0x4000D23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ActionMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000D24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Unbound;

	[global::Cpp2ILInjected.Token(Token = "0x4000D25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Cancel;

	[global::Cpp2ILInjected.Token(Token = "0x4000D26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float ElementSpacing;
}
