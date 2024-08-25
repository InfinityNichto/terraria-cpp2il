using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200019C")]
public class ClothesWindow_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC5C4", Offset = "0x9AC5C4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
	public static ClothesWindow_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4000CEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout ChangePreviewPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4000CEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout BuyButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout CancelButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout Savings;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Shirt;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Undershirt;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Pants;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Shoes;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Eyes;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Skin;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Style;

	[global::Cpp2ILInjected.Token(Token = "0x4000CF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ChangeButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ItemGrid_Layout StylesGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout StyleBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout SelectedStyleBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout LightnessBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000CFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Slider_Layout Lightness;

	[global::Cpp2ILInjected.Token(Token = "0x4000D00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout SaturationBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000D01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Slider_Layout Saturation;

	[global::Cpp2ILInjected.Token(Token = "0x4000D02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout HueBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000D03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Slider_Layout Hue;

	[global::Cpp2ILInjected.Token(Token = "0x4000D04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout ColourValue;
}
