using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017E RID: 382
[global::Cpp2ILInjected.Token(Token = "0x2000208")]
public class NetPlayStatusMenu_Layout : LayoutDefinition
{
	// Token: 0x06000B99 RID: 2969 RVA: 0x00023E10 File Offset: 0x00022010
	[global::Cpp2ILInjected.Token(Token = "0x6000CAE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF77C", Offset = "0x9CF77C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00023E13 File Offset: 0x00022013
	[global::Cpp2ILInjected.Token(Token = "0x6000CAF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF7C8", Offset = "0x9CF7C8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public NetPlayStatusMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000ED5 RID: 3797
	[global::Cpp2ILInjected.Token(Token = "0x4001322")]
	public static NetPlayStatusMenu_Layout Instance;

	// Token: 0x04000ED6 RID: 3798
	[global::Cpp2ILInjected.Token(Token = "0x4001323")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04000ED7 RID: 3799
	[global::Cpp2ILInjected.Token(Token = "0x4001324")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout ServerStatus;

	// Token: 0x04000ED8 RID: 3800
	[global::Cpp2ILInjected.Token(Token = "0x4001325")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Button_Layout SearchingIcon;

	// Token: 0x04000ED9 RID: 3801
	[global::Cpp2ILInjected.Token(Token = "0x4001326")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Cancel;
}
