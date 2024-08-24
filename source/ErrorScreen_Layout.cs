using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200016D RID: 365
[global::Cpp2ILInjected.Token(Token = "0x20001F7")]
public class ErrorScreen_Layout : LayoutDefinition
{
	// Token: 0x06000B79 RID: 2937 RVA: 0x00023DB0 File Offset: 0x00021FB0
	[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CED84", Offset = "0x9CED84", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00023DB3 File Offset: 0x00021FB3
	[global::Cpp2ILInjected.Token(Token = "0x6000C8F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEDD0", Offset = "0x9CEDD0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ErrorScreen_Layout()
	{
		throw null;
	}

	// Token: 0x04000DFD RID: 3581
	[global::Cpp2ILInjected.Token(Token = "0x400124A")]
	public static ErrorScreen_Layout Instance;

	// Token: 0x04000DFE RID: 3582
	[global::Cpp2ILInjected.Token(Token = "0x400124B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04000DFF RID: 3583
	[global::Cpp2ILInjected.Token(Token = "0x400124C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
