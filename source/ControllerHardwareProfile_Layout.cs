using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000128")]
public class ControllerHardwareProfile_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40009FD")]
	public static ControllerHardwareProfile_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40009FE")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40009FF")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A00")]
	public DraggableItemGrid_Layout OptionGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A01")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A02")]
	public TransactionButton_Layout ResetSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A03")]
	public TransactionButton_Layout Clear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A04")]
	public TransactionButton_Layout EditMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A05")]
	public ControllerProfileMappingEntry_Layout PulldownTemplate;

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x120D944", Offset = "0x120D944", VA = "0x120D944")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x120D9A0", Offset = "0x120D9A0", VA = "0x120D9A0")]
	public ControllerHardwareProfile_Layout()
	{
	}
}
