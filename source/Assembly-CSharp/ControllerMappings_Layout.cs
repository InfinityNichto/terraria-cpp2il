using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200012A RID: 298
[global::Cpp2ILInjected.Token(Token = "0x20001A5")]
public class ControllerMappings_Layout : LayoutDefinition
{
	// Token: 0x06000A63 RID: 2659 RVA: 0x00023A6E File Offset: 0x00021C6E
	[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE854", Offset = "0x9AE854", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00023A71 File Offset: 0x00021C71
	[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE8A0", Offset = "0x9AE8A0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerMappings_Layout()
	{
		throw null;
	}

	// Token: 0x04000A13 RID: 2579
	[global::Cpp2ILInjected.Token(Token = "0x4000DAD")]
	public static ControllerMappings_Layout Instance;

	// Token: 0x04000A14 RID: 2580
	[global::Cpp2ILInjected.Token(Token = "0x4000DAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000A15 RID: 2581
	[global::Cpp2ILInjected.Token(Token = "0x4000DAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000A16 RID: 2582
	[global::Cpp2ILInjected.Token(Token = "0x4000DB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000A17 RID: 2583
	[global::Cpp2ILInjected.Token(Token = "0x4000DB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000A18 RID: 2584
	[global::Cpp2ILInjected.Token(Token = "0x4000DB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04000A19 RID: 2585
	[global::Cpp2ILInjected.Token(Token = "0x4000DB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ControllerMappingsCategories_Layout Categories;

	// Token: 0x04000A1A RID: 2586
	[global::Cpp2ILInjected.Token(Token = "0x4000DB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Close;

	// Token: 0x04000A1B RID: 2587
	[global::Cpp2ILInjected.Token(Token = "0x4000DB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x04000A1C RID: 2588
	[global::Cpp2ILInjected.Token(Token = "0x4000DB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Clear;

	// Token: 0x04000A1D RID: 2589
	[global::Cpp2ILInjected.Token(Token = "0x4000DB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x04000A1E RID: 2590
	[global::Cpp2ILInjected.Token(Token = "0x4000DB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
