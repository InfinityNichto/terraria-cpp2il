using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000174 RID: 372
[global::Cpp2ILInjected.Token(Token = "0x20001FE")]
public class LowDiskSpacePopup_Layout : LayoutDefinition
{
	// Token: 0x06000B87 RID: 2951 RVA: 0x00023DDA File Offset: 0x00021FDA
	[global::Cpp2ILInjected.Token(Token = "0x6000C9C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF1A4", Offset = "0x9CF1A4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00023DDD File Offset: 0x00021FDD
	[global::Cpp2ILInjected.Token(Token = "0x6000C9D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF1F0", Offset = "0x9CF1F0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LowDiskSpacePopup_Layout()
	{
		throw null;
	}

	// Token: 0x04000E58 RID: 3672
	[global::Cpp2ILInjected.Token(Token = "0x40012A5")]
	public static LowDiskSpacePopup_Layout Instance;

	// Token: 0x04000E59 RID: 3673
	[global::Cpp2ILInjected.Token(Token = "0x40012A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04000E5A RID: 3674
	[global::Cpp2ILInjected.Token(Token = "0x40012A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;

	// Token: 0x04000E5B RID: 3675
	[global::Cpp2ILInjected.Token(Token = "0x40012A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Continue;
}
