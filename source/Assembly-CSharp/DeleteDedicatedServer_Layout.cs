using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200016A RID: 362
[global::Cpp2ILInjected.Token(Token = "0x20001F4")]
public class DeleteDedicatedServer_Layout : LayoutDefinition
{
	// Token: 0x06000B73 RID: 2931 RVA: 0x00023D9E File Offset: 0x00021F9E
	[global::Cpp2ILInjected.Token(Token = "0x6000C88")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEB98", Offset = "0x9CEB98", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00023DA1 File Offset: 0x00021FA1
	[global::Cpp2ILInjected.Token(Token = "0x6000C89")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEBE4", Offset = "0x9CEBE4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public DeleteDedicatedServer_Layout()
	{
		throw null;
	}

	// Token: 0x04000DE8 RID: 3560
	[global::Cpp2ILInjected.Token(Token = "0x4001235")]
	public static DeleteDedicatedServer_Layout Instance;

	// Token: 0x04000DE9 RID: 3561
	[global::Cpp2ILInjected.Token(Token = "0x4001236")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000DEA RID: 3562
	[global::Cpp2ILInjected.Token(Token = "0x4001237")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000DEB RID: 3563
	[global::Cpp2ILInjected.Token(Token = "0x4001238")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000DEC RID: 3564
	[global::Cpp2ILInjected.Token(Token = "0x4001239")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	// Token: 0x04000DED RID: 3565
	[global::Cpp2ILInjected.Token(Token = "0x400123A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	// Token: 0x04000DEE RID: 3566
	[global::Cpp2ILInjected.Token(Token = "0x400123B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
