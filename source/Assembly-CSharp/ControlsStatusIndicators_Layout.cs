using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000145 RID: 325
[global::Cpp2ILInjected.Token(Token = "0x20001CA")]
public class ControlsStatusIndicators_Layout : LayoutDefinition
{
	// Token: 0x06000ADF RID: 2783 RVA: 0x00023BE2 File Offset: 0x00021DE2
	[global::Cpp2ILInjected.Token(Token = "0x6000BF2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5520", Offset = "0x9B5520", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00023BE5 File Offset: 0x00021DE5
	[global::Cpp2ILInjected.Token(Token = "0x6000BF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B556C", Offset = "0x9B556C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControlsStatusIndicators_Layout()
	{
		throw null;
	}

	// Token: 0x04000BB2 RID: 2994
	[global::Cpp2ILInjected.Token(Token = "0x4000FB5")]
	public static ControlsStatusIndicators_Layout Instance;

	// Token: 0x04000BB3 RID: 2995
	[global::Cpp2ILInjected.Token(Token = "0x4000FB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000BB4 RID: 2996
	[global::Cpp2ILInjected.Token(Token = "0x4000FB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SmartCursor;

	// Token: 0x04000BB5 RID: 2997
	[global::Cpp2ILInjected.Token(Token = "0x4000FB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout AimMode;

	// Token: 0x04000BB6 RID: 2998
	[global::Cpp2ILInjected.Token(Token = "0x4000FB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout TargetMode;

	// Token: 0x04000BB7 RID: 2999
	[global::Cpp2ILInjected.Token(Token = "0x4000FBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ControlsProfile;
}
