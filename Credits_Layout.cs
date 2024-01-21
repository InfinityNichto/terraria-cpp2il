using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016A")]
public class Credits_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DEE")]
	public static Credits_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DEF")]
	public StringButton_Layout Credits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DF0")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B38", Offset = "0x20C5B38", VA = "0x20C5B38")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B94", Offset = "0x20C5B94", VA = "0x20C5B94")]
	public Credits_Layout()
	{
	}
}
