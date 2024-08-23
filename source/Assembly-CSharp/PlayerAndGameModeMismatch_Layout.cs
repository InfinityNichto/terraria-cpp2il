using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017F RID: 383
[global::Cpp2ILInjected.Token(Token = "0x2000209")]
public class PlayerAndGameModeMismatch_Layout : LayoutDefinition
{
	// Token: 0x06000B9B RID: 2971 RVA: 0x00023E16 File Offset: 0x00022016
	[global::Cpp2ILInjected.Token(Token = "0x6000CB0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF820", Offset = "0x9CF820", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00023E19 File Offset: 0x00022019
	[global::Cpp2ILInjected.Token(Token = "0x6000CB1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF86C", Offset = "0x9CF86C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerAndGameModeMismatch_Layout()
	{
		throw null;
	}

	// Token: 0x04000EDA RID: 3802
	[global::Cpp2ILInjected.Token(Token = "0x4001327")]
	public static PlayerAndGameModeMismatch_Layout Instance;

	// Token: 0x04000EDB RID: 3803
	[global::Cpp2ILInjected.Token(Token = "0x4001328")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000EDC RID: 3804
	[global::Cpp2ILInjected.Token(Token = "0x4001329")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000EDD RID: 3805
	[global::Cpp2ILInjected.Token(Token = "0x400132A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000EDE RID: 3806
	[global::Cpp2ILInjected.Token(Token = "0x400132B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout Status;

	// Token: 0x04000EDF RID: 3807
	[global::Cpp2ILInjected.Token(Token = "0x400132C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x04000EE0 RID: 3808
	[global::Cpp2ILInjected.Token(Token = "0x400132D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout GameTip;
}
