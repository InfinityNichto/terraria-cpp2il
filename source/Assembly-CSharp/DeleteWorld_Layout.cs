using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200016C RID: 364
[global::Cpp2ILInjected.Token(Token = "0x20001F6")]
public class DeleteWorld_Layout : LayoutDefinition
{
	// Token: 0x06000B77 RID: 2935 RVA: 0x00023DAA File Offset: 0x00021FAA
	[global::Cpp2ILInjected.Token(Token = "0x6000C8C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CECE0", Offset = "0x9CECE0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00023DAD File Offset: 0x00021FAD
	[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CED2C", Offset = "0x9CED2C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DeleteWorld_Layout()
	{
		throw null;
	}

	// Token: 0x04000DF6 RID: 3574
	[global::Cpp2ILInjected.Token(Token = "0x4001243")]
	public static DeleteWorld_Layout Instance;

	// Token: 0x04000DF7 RID: 3575
	[global::Cpp2ILInjected.Token(Token = "0x4001244")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000DF8 RID: 3576
	[global::Cpp2ILInjected.Token(Token = "0x4001245")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000DF9 RID: 3577
	[global::Cpp2ILInjected.Token(Token = "0x4001246")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000DFA RID: 3578
	[global::Cpp2ILInjected.Token(Token = "0x4001247")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	// Token: 0x04000DFB RID: 3579
	[global::Cpp2ILInjected.Token(Token = "0x4001248")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	// Token: 0x04000DFC RID: 3580
	[global::Cpp2ILInjected.Token(Token = "0x4001249")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
