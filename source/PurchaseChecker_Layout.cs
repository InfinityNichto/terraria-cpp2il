using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000231")]
public class PurchaseChecker_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CFA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D15B8", Offset = "0x9D15B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CFB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1604", Offset = "0x9D1604", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PurchaseChecker_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001697")]
	public static PurchaseChecker_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001698")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Information;

	[global::Cpp2ILInjected.Token(Token = "0x4001699")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Retry;

	[global::Cpp2ILInjected.Token(Token = "0x400169A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Store;

	[global::Cpp2ILInjected.Token(Token = "0x400169B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;
}
