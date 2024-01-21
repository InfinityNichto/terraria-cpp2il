using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000168")]
public class Mana_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DC2")]
	public static Mana_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DC3")]
	public bool HideWhenInventoryOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DC4")]
	public String_Layout Mana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DC5")]
	public String_Layout ManaHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DC6")]
	public String_Layout ManaValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000DC7")]
	public String_Layout ManaValueHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000DC8")]
	public float StarScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000DC9")]
	public ItemGrid_Layout ManaGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000DCA")]
	public String_Layout ManaController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000DCB")]
	public String_Layout ManaControllerHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000DCC")]
	public String_Layout ManaValueController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000DCD")]
	public String_Layout ManaValueControllerHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000DCE")]
	public ItemGrid_Layout ManaGridController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000DCF")]
	public ItemGrid_Layout ManaGridHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000DD0")]
	public ItemGrid_Layout ManaGridControllerHorizontal;

	[Cpp2IlInjected.Token(Token = "0x6000B76")]
	[Cpp2IlInjected.Address(RVA = "0x12E2318", Offset = "0x12E2318", VA = "0x12E2318")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B77")]
	[Cpp2IlInjected.Address(RVA = "0x12E2374", Offset = "0x12E2374", VA = "0x12E2374")]
	public Mana_Layout()
	{
	}
}
