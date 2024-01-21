using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000124")]
public class Chest_Layout : PageControllerLayoutDefinition<Chest_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40009BC")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40009BD")]
	public String_Layout TitleController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40009BE")]
	public String_Layout TitleTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40009BF")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40009C0")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40009C1")]
	public ItemGrid_Layout ChestGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40009C2")]
	public ItemGrid_Layout HorizontalChestGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40009C3")]
	public PopoutMenu_Layout Menu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40009C4")]
	public TransactionButton_Layout ChestRename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40009C5")]
	public TransactionButton_Layout ChestRename_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40009C6")]
	public TransactionButton_Layout ChestRestock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40009C7")]
	public TransactionButton_Layout ChestRestock_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40009C8")]
	public TransactionButton_Layout ChestQuickStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40009C9")]
	public TransactionButton_Layout ChestDepositAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40009CA")]
	public TransactionButton_Layout ChestDepositAll_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40009CB")]
	public TransactionButton_Layout ChestLootAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40009CC")]
	public TransactionButton_Layout ChestLootAll_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40009CD")]
	public TransactionButton_Layout LootButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40009CE")]
	public TransactionButton_Layout Favorite;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ItemGrid_Layout DisplayChestGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x12050EC", Offset = "0x12050EC", VA = "0x12050EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x1205164", Offset = "0x1205164", VA = "0x1205164")]
	public Chest_Layout()
	{
	}
}
