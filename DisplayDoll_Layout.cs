using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200014D")]
public class DisplayDoll_Layout : PageControllerLayoutDefinition<DisplayDoll_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000C51")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000C52")]
	public float AmourScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000C53")]
	public float ArmourHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000C54")]
	public ItemGrid_Layout ArmourDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000C55")]
	public ItemGrid_Layout Armor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000C56")]
	public float AccessoryScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000C57")]
	public float AccessoryHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000C58")]
	public ItemGrid_Layout AccessoryDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000C59")]
	public ItemGrid_Layout Accessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000C5A")]
	public TransactionButton_Layout RemoveButton;

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x20CC6C8", Offset = "0x20CC6C8", VA = "0x20CC6C8")]
	public DisplayDoll_Layout()
	{
	}
}
