using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200012B")]
public class ControllerMappings_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000A1C")]
	public static ControllerMappings_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A1D")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A1E")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A1F")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A20")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A21")]
	public DraggableItemGrid_Layout OptionGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A22")]
	public ControllerMappingsCategories_Layout Categories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A23")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A24")]
	public TransactionButton_Layout ResetSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A25")]
	public TransactionButton_Layout Clear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000A26")]
	public TransactionButton_Layout EditMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000A27")]
	public ControllerMappingEntry_Layout PulldownTemplate;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x120FEF0", Offset = "0x120FEF0", VA = "0x120FEF0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x120FF4C", Offset = "0x120FF4C", VA = "0x120FF4C")]
	public ControllerMappings_Layout()
	{
	}
}
