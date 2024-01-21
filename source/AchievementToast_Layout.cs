using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000116")]
public class AchievementToast_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40008DD")]
	public static AchievementToast_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40008DE")]
	public Panel_Layout achievementBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40008DF")]
	public String_Layout achievementTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40008E0")]
	public StringButton_Layout achievementIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40008E1")]
	public int ToastsSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40008E2")]
	public int ToastsTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40008E3")]
	public bool ReverseOrder;

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x11FC394", Offset = "0x11FC394", VA = "0x11FC394")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x11FC3F0", Offset = "0x11FC3F0", VA = "0x11FC3F0")]
	public AchievementToast_Layout()
	{
	}
}
