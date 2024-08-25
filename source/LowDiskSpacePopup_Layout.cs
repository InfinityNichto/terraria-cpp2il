using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001FE")]
public class LowDiskSpacePopup_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C9C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF1A4", Offset = "0x9CF1A4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C9D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF1F0", Offset = "0x9CF1F0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LowDiskSpacePopup_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012A5")]
	public static LowDiskSpacePopup_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x40012A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;

	[global::Cpp2ILInjected.Token(Token = "0x40012A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Continue;
}
