using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200016B RID: 363
[global::Cpp2ILInjected.Token(Token = "0x20001F5")]
public class DeletePlayer_Layout : LayoutDefinition
{
	// Token: 0x06000B75 RID: 2933 RVA: 0x00023DA4 File Offset: 0x00021FA4
	[global::Cpp2ILInjected.Token(Token = "0x6000C8A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEC3C", Offset = "0x9CEC3C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00023DA7 File Offset: 0x00021FA7
	[global::Cpp2ILInjected.Token(Token = "0x6000C8B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEC88", Offset = "0x9CEC88", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DeletePlayer_Layout()
	{
		throw null;
	}

	// Token: 0x04000DEF RID: 3567
	[global::Cpp2ILInjected.Token(Token = "0x400123C")]
	public static DeletePlayer_Layout Instance;

	// Token: 0x04000DF0 RID: 3568
	[global::Cpp2ILInjected.Token(Token = "0x400123D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000DF1 RID: 3569
	[global::Cpp2ILInjected.Token(Token = "0x400123E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000DF2 RID: 3570
	[global::Cpp2ILInjected.Token(Token = "0x400123F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000DF3 RID: 3571
	[global::Cpp2ILInjected.Token(Token = "0x4001240")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	// Token: 0x04000DF4 RID: 3572
	[global::Cpp2ILInjected.Token(Token = "0x4001241")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	// Token: 0x04000DF5 RID: 3573
	[global::Cpp2ILInjected.Token(Token = "0x4001242")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
