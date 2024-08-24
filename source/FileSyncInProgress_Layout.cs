using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200016E RID: 366
[global::Cpp2ILInjected.Token(Token = "0x20001F8")]
public class FileSyncInProgress_Layout : LayoutDefinition
{
	// Token: 0x06000B7B RID: 2939 RVA: 0x00023DB6 File Offset: 0x00021FB6
	[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEE28", Offset = "0x9CEE28", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00023DB9 File Offset: 0x00021FB9
	[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEE74", Offset = "0x9CEE74", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public FileSyncInProgress_Layout()
	{
		throw null;
	}

	// Token: 0x04000E00 RID: 3584
	[global::Cpp2ILInjected.Token(Token = "0x400124D")]
	public static FileSyncInProgress_Layout Instance;

	// Token: 0x04000E01 RID: 3585
	[global::Cpp2ILInjected.Token(Token = "0x400124E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Greyout;

	// Token: 0x04000E02 RID: 3586
	[global::Cpp2ILInjected.Token(Token = "0x400124F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000E03 RID: 3587
	[global::Cpp2ILInjected.Token(Token = "0x4001250")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Status;

	// Token: 0x04000E04 RID: 3588
	[global::Cpp2ILInjected.Token(Token = "0x4001251")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;
}
