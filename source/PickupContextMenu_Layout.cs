using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200022E")]
public class PickupContextMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CF4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D13CC", Offset = "0x9D13CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1418", Offset = "0x9D1418", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PickupContextMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001679")]
	public static PickupContextMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400167A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout LeftThrow;

	[global::Cpp2ILInjected.Token(Token = "0x400167B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout LeftTrash;

	[global::Cpp2ILInjected.Token(Token = "0x400167C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout LeftDeposit;

	[global::Cpp2ILInjected.Token(Token = "0x400167D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout RightThrow;

	[global::Cpp2ILInjected.Token(Token = "0x400167E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RightTrash;

	[global::Cpp2ILInjected.Token(Token = "0x400167F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout RightDeposit;
}
