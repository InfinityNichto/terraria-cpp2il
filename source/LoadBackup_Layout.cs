using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001FA")]
public class LoadBackup_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEF70", Offset = "0x9CEF70", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C95")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEFBC", Offset = "0x9CEFBC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LoadBackup_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001295")]
	public static LoadBackup_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001296")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public LoadWorld LoadWorld;

	[global::Cpp2ILInjected.Token(Token = "0x4001297")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public WorldNoBackup WorldNoBackup;
}
