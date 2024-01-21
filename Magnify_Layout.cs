using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000167")]
public class Magnify_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DBE")]
	public static Magnify_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DBF")]
	public float WorldZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DC0")]
	public int BufferZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DC1")]
	public Panel_Layout Panel;

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x12E16D8", Offset = "0x12E16D8", VA = "0x12E16D8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x12E1734", Offset = "0x12E1734", VA = "0x12E1734")]
	public Magnify_Layout()
	{
	}
}
