using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200023E")]
public class SaveSyncStatus_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D19")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D25FC", Offset = "0x9D25FC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D1A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2648", Offset = "0x9D2648", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSyncStatus_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40017D6")]
	public static SaveSyncStatus_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40017D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x40017D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;
}
