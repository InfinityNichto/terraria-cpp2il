using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000182")]
public class PlayerName_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000F21")]
	public static PlayerName_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F22")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F23")]
	public String_Layout InputCharacterName;

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x10B6CD8", Offset = "0x10B6CD8", VA = "0x10B6CD8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x10B6D34", Offset = "0x10B6D34", VA = "0x10B6D34")]
	public PlayerName_Layout()
	{
	}
}
