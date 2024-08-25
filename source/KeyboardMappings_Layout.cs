using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
public class KeyboardMappings_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C52")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBD14", Offset = "0x9CBD14", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C53")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBD60", Offset = "0x9CBD60", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public KeyboardMappings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40011DA")]
	public static KeyboardMappings_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40011DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40011DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40011DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40011DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x40011DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40011E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public KeyboardMappingsCategories_Layout Categories;

	[global::Cpp2ILInjected.Token(Token = "0x40011E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40011E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ResetSettings;

	[global::Cpp2ILInjected.Token(Token = "0x40011E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Clear;

	[global::Cpp2ILInjected.Token(Token = "0x40011E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout EditMapping;

	[global::Cpp2ILInjected.Token(Token = "0x40011E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Defaults;

	[global::Cpp2ILInjected.Token(Token = "0x40011E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
