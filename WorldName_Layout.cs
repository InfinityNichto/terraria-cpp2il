using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000197")]
public class WorldName_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40010C9")]
	public static WorldName_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40010CA")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40010CB")]
	public String_Layout InputWorldName;

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x14FB160", Offset = "0x14FB160", VA = "0x14FB160")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD5")]
	[Cpp2IlInjected.Address(RVA = "0x14FB1BC", Offset = "0x14FB1BC", VA = "0x14FB1BC")]
	public WorldName_Layout()
	{
	}
}
