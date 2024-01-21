using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000166")]
public class LeftPageControlsBanner_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DB9")]
	public static LeftPageControlsBanner_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DBA")]
	public bool RedirectToMainControlsBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DBB")]
	public ItemGrid_Layout Actions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DBC")]
	public TransactionButton_Layout ActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DBD")]
	public TransactionButton_Layout ActionStyleMultiple;

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x12DB5EC", Offset = "0x12DB5EC", VA = "0x12DB5EC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x12DB648", Offset = "0x12DB648", VA = "0x12DB648")]
	public LeftPageControlsBanner_Layout()
	{
	}
}
