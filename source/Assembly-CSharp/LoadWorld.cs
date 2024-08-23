using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000171 RID: 369
[global::Cpp2ILInjected.Token(Token = "0x20001FB")]
[Serializable]
public class LoadWorld
{
	// Token: 0x06000B81 RID: 2945 RVA: 0x00023DC8 File Offset: 0x00021FC8
	[global::Cpp2ILInjected.Token(Token = "0x6000C96")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF014", Offset = "0x9CF014", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00023DCB File Offset: 0x00021FCB
	[global::Cpp2ILInjected.Token(Token = "0x6000C97")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF060", Offset = "0x9CF060", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public LoadWorld()
	{
		throw null;
	}

	// Token: 0x04000E4B RID: 3659
	[global::Cpp2ILInjected.Token(Token = "0x4001298")]
	public static LoadWorld Instance;

	// Token: 0x04000E4C RID: 3660
	[global::Cpp2ILInjected.Token(Token = "0x4001299")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public StringButton_Layout Status;

	// Token: 0x04000E4D RID: 3661
	[global::Cpp2ILInjected.Token(Token = "0x400129A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Load;

	// Token: 0x04000E4E RID: 3662
	[global::Cpp2ILInjected.Token(Token = "0x400129B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
