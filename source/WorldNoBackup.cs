using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
[Serializable]
public class WorldNoBackup
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C98")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF068", Offset = "0x9CF068", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF0B4", Offset = "0x9CF0B4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public WorldNoBackup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400129C")]
	public static WorldNoBackup Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400129D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x400129E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Description;

	[global::Cpp2ILInjected.Token(Token = "0x400129F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
