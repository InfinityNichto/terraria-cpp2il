using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000185")]
public class QuitConfirm_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000F53")]
	public static QuitConfirm_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F54")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F55")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000F56")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000F57")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000F58")]
	public TransactionButton_Layout Quit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000F59")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x10BD1D8", Offset = "0x10BD1D8", VA = "0x10BD1D8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x10BD234", Offset = "0x10BD234", VA = "0x10BD234")]
	public QuitConfirm_Layout()
	{
	}
}
