using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000192")]
public class SettingsPauseMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001061")]
	public static SettingsPauseMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001062")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001063")]
	public Panel_Layout JourneyBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001064")]
	public TransactionButton_Layout Settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001065")]
	public TransactionButton_Layout Home;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001066")]
	public TransactionButton_Layout Achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001067")]
	public TransactionButton_Layout Bestiary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001068")]
	public TransactionButton_Layout JourneySettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001069")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400106A")]
	public float ButtonExtraPadding;

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x105F6D4", Offset = "0x105F6D4", VA = "0x105F6D4")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x105F730", Offset = "0x105F730", VA = "0x105F730")]
	public SettingsPauseMenu_Layout()
	{
	}
}
