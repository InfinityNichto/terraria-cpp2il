using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001AF RID: 431
[global::Cpp2ILInjected.Token(Token = "0x200023E")]
public class SaveSyncStatus_Layout : LayoutDefinition
{
	// Token: 0x06000BFF RID: 3071 RVA: 0x00023F42 File Offset: 0x00022142
	[global::Cpp2ILInjected.Token(Token = "0x6000D19")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D25FC", Offset = "0x9D25FC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00023F45 File Offset: 0x00022145
	[global::Cpp2ILInjected.Token(Token = "0x6000D1A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2648", Offset = "0x9D2648", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSyncStatus_Layout()
	{
		throw null;
	}

	// Token: 0x04001321 RID: 4897
	[global::Cpp2ILInjected.Token(Token = "0x40017D6")]
	public static SaveSyncStatus_Layout Instance;

	// Token: 0x04001322 RID: 4898
	[global::Cpp2ILInjected.Token(Token = "0x40017D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04001323 RID: 4899
	[global::Cpp2ILInjected.Token(Token = "0x40017D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;
}
