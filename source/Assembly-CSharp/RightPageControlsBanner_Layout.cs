using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001A8 RID: 424
[global::Cpp2ILInjected.Token(Token = "0x2000237")]
public class RightPageControlsBanner_Layout : LayoutDefinition
{
	// Token: 0x06000BF0 RID: 3056 RVA: 0x00023F15 File Offset: 0x00022115
	[global::Cpp2ILInjected.Token(Token = "0x6000D0A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1FD8", Offset = "0x9D1FD8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00023F18 File Offset: 0x00022118
	[global::Cpp2ILInjected.Token(Token = "0x6000D0B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2024", Offset = "0x9D2024", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public RightPageControlsBanner_Layout()
	{
		throw null;
	}

	// Token: 0x0400128B RID: 4747
	[global::Cpp2ILInjected.Token(Token = "0x4001740")]
	public static RightPageControlsBanner_Layout Instance;

	// Token: 0x0400128C RID: 4748
	[global::Cpp2ILInjected.Token(Token = "0x4001741")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool RedirectToMainControlsBanner;

	// Token: 0x0400128D RID: 4749
	[global::Cpp2ILInjected.Token(Token = "0x4001742")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Actions;

	// Token: 0x0400128E RID: 4750
	[global::Cpp2ILInjected.Token(Token = "0x4001743")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ActionStyle;

	// Token: 0x0400128F RID: 4751
	[global::Cpp2ILInjected.Token(Token = "0x4001744")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ActionStyleMultiple;
}
