using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
[Serializable]
public class ControllerProfileMappingEntry_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B74")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE8F8", Offset = "0x9AE8F8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControllerProfileMappingEntry_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000DB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout PulldownButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout IconTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout PulldownGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Action;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ActionMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Unbound;

	[global::Cpp2ILInjected.Token(Token = "0x4000DBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout Bound;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Cancel;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ClearBinding;

	[global::Cpp2ILInjected.Token(Token = "0x4000DC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float ElementSpacing;
}
