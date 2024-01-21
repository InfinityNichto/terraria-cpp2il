using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200019C")]
public class NetplayStatusText_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001149")]
	public static NetplayStatusText_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400114A")]
	public String_Layout StatusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400114B")]
	public string TestString;

	[Cpp2IlInjected.Token(Token = "0x6000BE2")]
	[Cpp2IlInjected.Address(RVA = "0x10B2C04", Offset = "0x10B2C04", VA = "0x10B2C04")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE3")]
	[Cpp2IlInjected.Address(RVA = "0x10B2C60", Offset = "0x10B2C60", VA = "0x10B2C60")]
	public NetplayStatusText_Layout()
	{
	}
}
