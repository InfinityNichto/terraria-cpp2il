using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001A4")]
public class PurchaseChecker_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001237")]
	public static PurchaseChecker_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001238")]
	public String_Layout Information;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001239")]
	public TransactionButton_Layout Retry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400123A")]
	public TransactionButton_Layout Store;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400123B")]
	public Button_Layout SearchingIcon;

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x10BCF30", Offset = "0x10BCF30", VA = "0x10BCF30")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x10BCF8C", Offset = "0x10BCF8C", VA = "0x10BCF8C")]
	public PurchaseChecker_Layout()
	{
	}
}
