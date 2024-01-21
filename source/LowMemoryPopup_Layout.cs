using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000176")]
public class LowMemoryPopup_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E65")]
	public static LowMemoryPopup_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E66")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E67")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E68")]
	public TransactionButton_Layout Continue;

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x12DF9BC", Offset = "0x12DF9BC", VA = "0x12DF9BC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x12DFA18", Offset = "0x12DFA18", VA = "0x12DFA18")]
	public LowMemoryPopup_Layout()
	{
	}
}
