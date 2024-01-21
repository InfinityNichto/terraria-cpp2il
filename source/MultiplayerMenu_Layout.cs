using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200017E")]
public class MultiplayerMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000EDA")]
	public static MultiplayerMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000EDB")]
	public StringButton_Layout Join;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000EDC")]
	public StringButton_Layout HostAndPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000EDD")]
	public StringButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x10B296C", Offset = "0x10B296C", VA = "0x10B296C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x10B29C8", Offset = "0x10B29C8", VA = "0x10B29C8")]
	public MultiplayerMenu_Layout()
	{
	}
}
