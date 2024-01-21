using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001AF")]
public class SaveSyncStatus_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001311")]
	public static SaveSyncStatus_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001312")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001313")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0xF9C238", Offset = "0xF9C238", VA = "0xF9C238")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0xF9C294", Offset = "0xF9C294", VA = "0xF9C294")]
	public SaveSyncStatus_Layout()
	{
	}
}
