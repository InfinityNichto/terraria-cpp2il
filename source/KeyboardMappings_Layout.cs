using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000163 RID: 355
[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
public class KeyboardMappings_Layout : LayoutDefinition
{
	// Token: 0x06000B3D RID: 2877 RVA: 0x00023CFC File Offset: 0x00021EFC
	[global::Cpp2ILInjected.Token(Token = "0x6000C52")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBD14", Offset = "0x9CBD14", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00023CFF File Offset: 0x00021EFF
	[global::Cpp2ILInjected.Token(Token = "0x6000C53")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBD60", Offset = "0x9CBD60", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public KeyboardMappings_Layout()
	{
		throw null;
	}

	// Token: 0x04000D9E RID: 3486
	[global::Cpp2ILInjected.Token(Token = "0x40011DA")]
	public static KeyboardMappings_Layout Instance;

	// Token: 0x04000D9F RID: 3487
	[global::Cpp2ILInjected.Token(Token = "0x40011DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04000DA0 RID: 3488
	[global::Cpp2ILInjected.Token(Token = "0x40011DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000DA1 RID: 3489
	[global::Cpp2ILInjected.Token(Token = "0x40011DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000DA2 RID: 3490
	[global::Cpp2ILInjected.Token(Token = "0x40011DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000DA3 RID: 3491
	[global::Cpp2ILInjected.Token(Token = "0x40011DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04000DA4 RID: 3492
	[global::Cpp2ILInjected.Token(Token = "0x40011E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public KeyboardMappingsCategories_Layout Categories;

	// Token: 0x04000DA5 RID: 3493
	[global::Cpp2ILInjected.Token(Token = "0x40011E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Close;

	// Token: 0x04000DA6 RID: 3494
	[global::Cpp2ILInjected.Token(Token = "0x40011E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x04000DA7 RID: 3495
	[global::Cpp2ILInjected.Token(Token = "0x40011E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Clear;

	// Token: 0x04000DA8 RID: 3496
	[global::Cpp2ILInjected.Token(Token = "0x40011E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x04000DA9 RID: 3497
	[global::Cpp2ILInjected.Token(Token = "0x40011E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Defaults;

	// Token: 0x04000DAA RID: 3498
	[global::Cpp2ILInjected.Token(Token = "0x40011E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
