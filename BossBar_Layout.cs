using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200011B")]
public class BossBar_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000956")]
	public static BossBar_Layout Instance;

	[Cpp2IlInjected.Token(Token = "0x4000957")]
	public static BossBar_Layout InstanceMobile;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000958")]
	public Panel_Layout BarBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000959")]
	public Panel_Layout BarFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400095A")]
	public TransactionButton_Layout BossIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400095B")]
	public Panel_Layout ControllerBarBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400095C")]
	public Panel_Layout ControllerBarFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400095D")]
	public TransactionButton_Layout ControllerBossIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400095E")]
	public Texture_Layout LifeCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400095F")]
	public Texture_Layout LifeFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000960")]
	public Texture_Layout ShieldCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000961")]
	public Texture_Layout ShieldFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000962")]
	public bool RemainingOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000963")]
	public String_Layout HealthAmount;

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x1200CBC", Offset = "0x1200CBC", VA = "0x1200CBC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x1200D3C", Offset = "0x1200D3C", VA = "0x1200D3C")]
	public BossBar_Layout()
	{
	}
}
