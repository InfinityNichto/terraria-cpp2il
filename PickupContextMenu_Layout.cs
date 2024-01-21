using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001A1")]
public class PickupContextMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001219")]
	public static PickupContextMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400121A")]
	public TransactionButton_Layout LeftThrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400121B")]
	public TransactionButton_Layout LeftTrash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400121C")]
	public TransactionButton_Layout LeftDeposit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400121D")]
	public TransactionButton_Layout RightThrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400121E")]
	public TransactionButton_Layout RightTrash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400121F")]
	public TransactionButton_Layout RightDeposit;

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x10B4BEC", Offset = "0x10B4BEC", VA = "0x10B4BEC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x10B4C48", Offset = "0x10B4C48", VA = "0x10B4C48")]
	public PickupContextMenu_Layout()
	{
	}
}
