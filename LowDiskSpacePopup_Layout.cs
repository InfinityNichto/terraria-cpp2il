using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000175")]
public class LowDiskSpacePopup_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E61")]
	public static LowDiskSpacePopup_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E62")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E63")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E64")]
	public TransactionButton_Layout Continue;

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x12DF8E4", Offset = "0x12DF8E4", VA = "0x12DF8E4")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x12DF940", Offset = "0x12DF940", VA = "0x12DF940")]
	public LowDiskSpacePopup_Layout()
	{
	}
}
