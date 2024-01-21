using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200015B")]
public class InventoryTransactions_Layout : PageControllerLayoutDefinition<InventoryTransactions_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D2A")]
	public TransactionButton_Layout SellButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D2B")]
	public String_Layout SellValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D2C")]
	public String_Layout ControllerSellValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D2D")]
	public TransactionButton_Layout OpenButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D2E")]
	public TransactionButton_Layout UseButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000D2F")]
	public TransactionButton_Layout EquipButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000D30")]
	public TransactionButton_Layout DepositButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000D31")]
	public TransactionButton_Layout PlaceHatButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000D32")]
	public TransactionButton_Layout PlaceDollButton;

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x117887C", Offset = "0x117887C", VA = "0x117887C")]
	public InventoryTransactions_Layout()
	{
	}
}
