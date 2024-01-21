using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000177")]
public class LowMemorySettings_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E69")]
	public static LowMemorySettings_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E6A")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E6B")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E6C")]
	public TransactionButton_Layout Continue;

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x12DFA94", Offset = "0x12DFA94", VA = "0x12DFA94")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x12DFAF0", Offset = "0x12DFAF0", VA = "0x12DFAF0")]
	public LowMemorySettings_Layout()
	{
	}
}
