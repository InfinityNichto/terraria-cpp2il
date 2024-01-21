using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200017F")]
public class NetPlayStatusMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000EDE")]
	public static NetPlayStatusMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000EDF")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000EE0")]
	public StringButton_Layout ServerStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000EE1")]
	public Button_Layout SearchingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000EE2")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x10B2B2C", Offset = "0x10B2B2C", VA = "0x10B2B2C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x10B2B88", Offset = "0x10B2B88", VA = "0x10B2B88")]
	public NetPlayStatusMenu_Layout()
	{
	}
}
