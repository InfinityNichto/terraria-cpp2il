using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001FB")]
[Serializable]
public class LoadWorld
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C96")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF014", Offset = "0x9CF014", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C97")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF060", Offset = "0x9CF060", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public LoadWorld()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001298")]
	public static LoadWorld Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001299")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x400129A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Load;

	[global::Cpp2ILInjected.Token(Token = "0x400129B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
