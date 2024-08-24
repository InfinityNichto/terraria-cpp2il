using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000127 RID: 295
[global::Cpp2ILInjected.Token(Token = "0x200019F")]
public class ControllerHardwareProfile_Layout : LayoutDefinition
{
	// Token: 0x06000A5D RID: 2653 RVA: 0x00023A5C File Offset: 0x00021C5C
	[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC9B8", Offset = "0x9AC9B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00023A5F File Offset: 0x00021C5F
	[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACA04", Offset = "0x9ACA04", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerHardwareProfile_Layout()
	{
		throw null;
	}

	// Token: 0x040009F4 RID: 2548
	[global::Cpp2ILInjected.Token(Token = "0x4000D16")]
	public static ControllerHardwareProfile_Layout Instance;

	// Token: 0x040009F5 RID: 2549
	[global::Cpp2ILInjected.Token(Token = "0x4000D17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x040009F6 RID: 2550
	[global::Cpp2ILInjected.Token(Token = "0x4000D18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x040009F7 RID: 2551
	[global::Cpp2ILInjected.Token(Token = "0x4000D19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x040009F8 RID: 2552
	[global::Cpp2ILInjected.Token(Token = "0x4000D1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Close;

	// Token: 0x040009F9 RID: 2553
	[global::Cpp2ILInjected.Token(Token = "0x4000D1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x040009FA RID: 2554
	[global::Cpp2ILInjected.Token(Token = "0x4000D1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Clear;

	// Token: 0x040009FB RID: 2555
	[global::Cpp2ILInjected.Token(Token = "0x4000D1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x040009FC RID: 2556
	[global::Cpp2ILInjected.Token(Token = "0x4000D1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ControllerProfileMappingEntry_Layout PulldownTemplate;
}
