using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001A5")]
public class ControllerMappings_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE854", Offset = "0x9AE854", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE8A0", Offset = "0x9AE8A0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerMappings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000DAD")]
	public static ControllerMappings_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000DAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000DAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ControllerMappingsCategories_Layout Categories;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ResetSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Clear;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout EditMapping;

	[global::Cpp2ILInjected.Token(Token = "0x4000DB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
