using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000153")]
public class Hearts_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000CF0")]
	public static Hearts_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000CF1")]
	public bool HideWhenInventoryOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000CF2")]
	public String_Layout HealthTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000CF3")]
	public String_Layout HealthValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000CF4")]
	public float HeartsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000CF5")]
	public ItemGrid_Layout HeartsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000CF6")]
	public ItemGrid_Layout HeartsGridController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000CF7")]
	public String_Layout HealthTitleController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000CF8")]
	public String_Layout HealthValueController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000CF9")]
	public ItemGrid_Layout HorizontalHeartsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000CFA")]
	public ItemGrid_Layout HorizontalHeartsGridController;

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x116EDF8", Offset = "0x116EDF8", VA = "0x116EDF8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x116EE54", Offset = "0x116EE54", VA = "0x116EE54")]
	public Hearts_Layout()
	{
	}
}
