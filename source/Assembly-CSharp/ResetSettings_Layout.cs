using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000185 RID: 389
[global::Cpp2ILInjected.Token(Token = "0x200020F")]
public class ResetSettings_Layout : LayoutDefinition
{
	// Token: 0x06000BA7 RID: 2983 RVA: 0x00023E3A File Offset: 0x0002203A
	[global::Cpp2ILInjected.Token(Token = "0x6000CBC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFD54", Offset = "0x9CFD54", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00023E3D File Offset: 0x0002203D
	[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFDA0", Offset = "0x9CFDA0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ResetSettings_Layout()
	{
		throw null;
	}

	// Token: 0x04000F51 RID: 3921
	[global::Cpp2ILInjected.Token(Token = "0x400139E")]
	public static ResetSettings_Layout Instance;

	// Token: 0x04000F52 RID: 3922
	[global::Cpp2ILInjected.Token(Token = "0x400139F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000F53 RID: 3923
	[global::Cpp2ILInjected.Token(Token = "0x40013A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000F54 RID: 3924
	[global::Cpp2ILInjected.Token(Token = "0x40013A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000F55 RID: 3925
	[global::Cpp2ILInjected.Token(Token = "0x40013A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout DeletePrompt;

	// Token: 0x04000F56 RID: 3926
	[global::Cpp2ILInjected.Token(Token = "0x40013A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Yes;

	// Token: 0x04000F57 RID: 3927
	[global::Cpp2ILInjected.Token(Token = "0x40013A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout No;
}
