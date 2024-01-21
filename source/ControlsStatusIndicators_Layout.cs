using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000146")]
public class ControlsStatusIndicators_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000BBB")]
	public static ControlsStatusIndicators_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000BBC")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000BBD")]
	public TransactionButton_Layout SmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000BBE")]
	public TransactionButton_Layout AimMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000BBF")]
	public TransactionButton_Layout TargetMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000BC0")]
	public TransactionButton_Layout ControlsProfile;

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x20C2F2C", Offset = "0x20C2F2C", VA = "0x20C2F2C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x20C2F88", Offset = "0x20C2F88", VA = "0x20C2F88")]
	public ControlsStatusIndicators_Layout()
	{
	}
}
