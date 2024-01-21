using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000178")]
public class MainMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E6D")]
	public static MainMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E6E")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E6F")]
	public TransactionButton_Layout Singleplayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E70")]
	public TransactionButton_Layout Multiplayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000E71")]
	public TransactionButton_Layout Achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000E72")]
	public TransactionButton_Layout Settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000E73")]
	public TransactionButton_Layout Tutorial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000E74")]
	public TransactionButton_Layout Credits;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000E75")]
	public TransactionButton_Layout PurchaseFullGame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000E76")]
	public TransactionButton_Layout PlayerProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000E77")]
	public String_Layout VersionNumber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000E78")]
	public string VersionNumberText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000E79")]
	public String_Layout Copyright;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000E7A")]
	public string CopyrightText;

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x12E17B0", Offset = "0x12E17B0", VA = "0x12E17B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x12E180C", Offset = "0x12E180C", VA = "0x12E180C")]
	public MainMenu_Layout()
	{
	}
}
