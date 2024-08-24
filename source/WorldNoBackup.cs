using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000172 RID: 370
[global::Cpp2ILInjected.Token(Token = "0x20001FC")]
[Serializable]
public class WorldNoBackup
{
	// Token: 0x06000B83 RID: 2947 RVA: 0x00023DCE File Offset: 0x00021FCE
	[global::Cpp2ILInjected.Token(Token = "0x6000C98")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF068", Offset = "0x9CF068", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00023DD1 File Offset: 0x00021FD1
	[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF0B4", Offset = "0x9CF0B4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public WorldNoBackup()
	{
		throw null;
	}

	// Token: 0x04000E4F RID: 3663
	[global::Cpp2ILInjected.Token(Token = "0x400129C")]
	public static WorldNoBackup Instance;

	// Token: 0x04000E50 RID: 3664
	[global::Cpp2ILInjected.Token(Token = "0x400129D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public StringButton_Layout Status;

	// Token: 0x04000E51 RID: 3665
	[global::Cpp2ILInjected.Token(Token = "0x400129E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Description;

	// Token: 0x04000E52 RID: 3666
	[global::Cpp2ILInjected.Token(Token = "0x400129F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
