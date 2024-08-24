using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000126 RID: 294
[global::Cpp2ILInjected.Token(Token = "0x200019E")]
public class ControllerDisconnected_Layout : LayoutDefinition
{
	// Token: 0x06000A5B RID: 2651 RVA: 0x00023A56 File Offset: 0x00021C56
	[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC914", Offset = "0x9AC914", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00023A59 File Offset: 0x00021C59
	[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC960", Offset = "0x9AC960", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerDisconnected_Layout()
	{
		throw null;
	}

	// Token: 0x040009EB RID: 2539
	[global::Cpp2ILInjected.Token(Token = "0x4000D0D")]
	public static ControllerDisconnected_Layout Instance;

	// Token: 0x040009EC RID: 2540
	[global::Cpp2ILInjected.Token(Token = "0x4000D0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Greyout;

	// Token: 0x040009ED RID: 2541
	[global::Cpp2ILInjected.Token(Token = "0x4000D0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x040009EE RID: 2542
	[global::Cpp2ILInjected.Token(Token = "0x4000D10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Status;

	// Token: 0x040009EF RID: 2543
	[global::Cpp2ILInjected.Token(Token = "0x4000D11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;

	// Token: 0x040009F0 RID: 2544
	[global::Cpp2ILInjected.Token(Token = "0x4000D12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout SwitchBacking;

	// Token: 0x040009F1 RID: 2545
	[global::Cpp2ILInjected.Token(Token = "0x4000D13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout SwitchStatus;

	// Token: 0x040009F2 RID: 2546
	[global::Cpp2ILInjected.Token(Token = "0x4000D14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SwitchConfigure;

	// Token: 0x040009F3 RID: 2547
	[global::Cpp2ILInjected.Token(Token = "0x4000D15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Button_Layout SwitchSearchingIcon;
}
