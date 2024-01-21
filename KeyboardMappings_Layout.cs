using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000164")]
public class KeyboardMappings_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DA7")]
	public static KeyboardMappings_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DA8")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DA9")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DAA")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DAB")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000DAC")]
	public DraggableItemGrid_Layout OptionGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000DAD")]
	public KeyboardMappingsCategories_Layout Categories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000DAE")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000DAF")]
	public TransactionButton_Layout ResetSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000DB0")]
	public TransactionButton_Layout Clear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000DB1")]
	public TransactionButton_Layout EditMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000DB2")]
	public TransactionButton_Layout Defaults;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000DB3")]
	public ControllerMappingEntry_Layout PulldownTemplate;

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x12D5898", Offset = "0x12D5898", VA = "0x12D5898")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x12D58F4", Offset = "0x12D58F4", VA = "0x12D58F4")]
	public KeyboardMappings_Layout()
	{
	}
}
