using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016E")]
public class ErrorScreen_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E06")]
	public static ErrorScreen_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E07")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E08")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x20D236C", Offset = "0x20D236C", VA = "0x20D236C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x20D23C8", Offset = "0x20D23C8", VA = "0x20D23C8")]
	public ErrorScreen_Layout()
	{
	}
}
