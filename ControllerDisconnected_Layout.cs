using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000127")]
public class ControllerDisconnected_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40009F4")]
	public static ControllerDisconnected_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40009F5")]
	public Panel_Layout Greyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40009F6")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40009F7")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40009F8")]
	public Button_Layout SearchingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40009F9")]
	public Panel_Layout SwitchBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40009FA")]
	public String_Layout SwitchStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40009FB")]
	public TransactionButton_Layout SwitchConfigure;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40009FC")]
	public Button_Layout SwitchSearchingIcon;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x120D86C", Offset = "0x120D86C", VA = "0x120D86C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x120D8C8", Offset = "0x120D8C8", VA = "0x120D8C8")]
	public ControllerDisconnected_Layout()
	{
	}
}
