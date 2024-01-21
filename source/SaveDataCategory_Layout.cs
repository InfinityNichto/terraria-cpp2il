using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class SaveDataCategory_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40012C1")]
	public static SaveDataCategory_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40012C2")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40012C3")]
	public TransactionButton_Layout LocalPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40012C4")]
	public TransactionButton_Layout RemotePlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40012C5")]
	public TransactionButton_Layout LocalWorlds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40012C6")]
	public TransactionButton_Layout RemoteWorlds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40012C7")]
	public TransactionButton_Layout Upload;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40012C8")]
	public TransactionButton_Layout Download;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40012C9")]
	public TransactionButton_Layout UploadSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40012CA")]
	public TransactionButton_Layout DownloadSettings;

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0xF9BFB0", Offset = "0xF9BFB0", VA = "0xF9BFB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0xF9C00C", Offset = "0xF9C00C", VA = "0xF9C00C")]
	public SaveDataCategory_Layout()
	{
	}
}
