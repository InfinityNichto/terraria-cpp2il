using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000170 RID: 368
[global::Cpp2ILInjected.Token(Token = "0x20001FA")]
public class LoadBackup_Layout : LayoutDefinition
{
	// Token: 0x06000B7F RID: 2943 RVA: 0x00023DC2 File Offset: 0x00021FC2
	[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEF70", Offset = "0x9CEF70", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x00023DC5 File Offset: 0x00021FC5
	[global::Cpp2ILInjected.Token(Token = "0x6000C95")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEFBC", Offset = "0x9CEFBC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LoadBackup_Layout()
	{
		throw null;
	}

	// Token: 0x04000E48 RID: 3656
	[global::Cpp2ILInjected.Token(Token = "0x4001295")]
	public static LoadBackup_Layout Instance;

	// Token: 0x04000E49 RID: 3657
	[global::Cpp2ILInjected.Token(Token = "0x4001296")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public LoadWorld LoadWorld;

	// Token: 0x04000E4A RID: 3658
	[global::Cpp2ILInjected.Token(Token = "0x4001297")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public WorldNoBackup WorldNoBackup;
}
