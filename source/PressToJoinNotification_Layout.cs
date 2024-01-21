using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001A2")]
public class PressToJoinNotification_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001220")]
	public static PressToJoinNotification_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001221")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001222")]
	public String_Layout JoinText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001223")]
	public float DisplayTime;

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x10BC924", Offset = "0x10BC924", VA = "0x10BC924")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x10BC980", Offset = "0x10BC980", VA = "0x10BC980")]
	public PressToJoinNotification_Layout()
	{
	}
}
