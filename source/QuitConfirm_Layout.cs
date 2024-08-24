using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000184 RID: 388
[global::Cpp2ILInjected.Token(Token = "0x200020E")]
public class QuitConfirm_Layout : LayoutDefinition
{
	// Token: 0x06000BA5 RID: 2981 RVA: 0x00023E34 File Offset: 0x00022034
	[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFCB0", Offset = "0x9CFCB0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00023E37 File Offset: 0x00022037
	[global::Cpp2ILInjected.Token(Token = "0x6000CBB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFCFC", Offset = "0x9CFCFC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public QuitConfirm_Layout()
	{
		throw null;
	}

	// Token: 0x04000F4A RID: 3914
	[global::Cpp2ILInjected.Token(Token = "0x4001397")]
	public static QuitConfirm_Layout Instance;

	// Token: 0x04000F4B RID: 3915
	[global::Cpp2ILInjected.Token(Token = "0x4001398")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000F4C RID: 3916
	[global::Cpp2ILInjected.Token(Token = "0x4001399")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000F4D RID: 3917
	[global::Cpp2ILInjected.Token(Token = "0x400139A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000F4E RID: 3918
	[global::Cpp2ILInjected.Token(Token = "0x400139B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public StringButton_Layout Status;

	// Token: 0x04000F4F RID: 3919
	[global::Cpp2ILInjected.Token(Token = "0x400139C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Quit;

	// Token: 0x04000F50 RID: 3920
	[global::Cpp2ILInjected.Token(Token = "0x400139D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Back;
}
