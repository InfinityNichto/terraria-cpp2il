using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000124 RID: 292
[global::Cpp2ILInjected.Token(Token = "0x200019C")]
public class ClothesWindow_Layout : LayoutDefinition
{
	// Token: 0x06000A58 RID: 2648 RVA: 0x00023A4D File Offset: 0x00021C4D
	[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC5C4", Offset = "0x9AC5C4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00023A50 File Offset: 0x00021C50
	[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC610", Offset = "0x9AC610", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider_Layout), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public ClothesWindow_Layout()
	{
		throw null;
	}

	// Token: 0x040009C6 RID: 2502
	[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
	public static ClothesWindow_Layout Instance;

	// Token: 0x040009C7 RID: 2503
	[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x040009C8 RID: 2504
	[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x040009C9 RID: 2505
	[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040009CA RID: 2506
	[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	// Token: 0x040009CB RID: 2507
	[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	// Token: 0x040009CC RID: 2508
	[global::Cpp2ILInjected.Token(Token = "0x4000CEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout ChangePreviewPosition;

	// Token: 0x040009CD RID: 2509
	[global::Cpp2ILInjected.Token(Token = "0x4000CEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout BuyButton;

	// Token: 0x040009CE RID: 2510
	[global::Cpp2ILInjected.Token(Token = "0x4000CF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout CancelButton;

	// Token: 0x040009CF RID: 2511
	[global::Cpp2ILInjected.Token(Token = "0x4000CF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout Savings;

	// Token: 0x040009D0 RID: 2512
	[global::Cpp2ILInjected.Token(Token = "0x4000CF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Shirt;

	// Token: 0x040009D1 RID: 2513
	[global::Cpp2ILInjected.Token(Token = "0x4000CF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Undershirt;

	// Token: 0x040009D2 RID: 2514
	[global::Cpp2ILInjected.Token(Token = "0x4000CF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Pants;

	// Token: 0x040009D3 RID: 2515
	[global::Cpp2ILInjected.Token(Token = "0x4000CF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Shoes;

	// Token: 0x040009D4 RID: 2516
	[global::Cpp2ILInjected.Token(Token = "0x4000CF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Eyes;

	// Token: 0x040009D5 RID: 2517
	[global::Cpp2ILInjected.Token(Token = "0x4000CF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Skin;

	// Token: 0x040009D6 RID: 2518
	[global::Cpp2ILInjected.Token(Token = "0x4000CF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Style;

	// Token: 0x040009D7 RID: 2519
	[global::Cpp2ILInjected.Token(Token = "0x4000CF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ChangeButton;

	// Token: 0x040009D8 RID: 2520
	[global::Cpp2ILInjected.Token(Token = "0x4000CFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Close;

	// Token: 0x040009D9 RID: 2521
	[global::Cpp2ILInjected.Token(Token = "0x4000CFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ItemGrid_Layout StylesGrid;

	// Token: 0x040009DA RID: 2522
	[global::Cpp2ILInjected.Token(Token = "0x4000CFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout StyleBacking;

	// Token: 0x040009DB RID: 2523
	[global::Cpp2ILInjected.Token(Token = "0x4000CFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout SelectedStyleBacking;

	// Token: 0x040009DC RID: 2524
	[global::Cpp2ILInjected.Token(Token = "0x4000CFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x040009DD RID: 2525
	[global::Cpp2ILInjected.Token(Token = "0x4000CFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Slider_Layout Lightness;

	// Token: 0x040009DE RID: 2526
	[global::Cpp2ILInjected.Token(Token = "0x4000D00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x040009DF RID: 2527
	[global::Cpp2ILInjected.Token(Token = "0x4000D01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Slider_Layout Saturation;

	// Token: 0x040009E0 RID: 2528
	[global::Cpp2ILInjected.Token(Token = "0x4000D02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout HueBacking;

	// Token: 0x040009E1 RID: 2529
	[global::Cpp2ILInjected.Token(Token = "0x4000D03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Slider_Layout Hue;

	// Token: 0x040009E2 RID: 2530
	[global::Cpp2ILInjected.Token(Token = "0x4000D04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout ColourValue;
}
