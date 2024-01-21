using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000193")]
public class StatusMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x400106B")]
	public static StatusMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400106C")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400106D")]
	public String_Layout GameTip;

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x10637AC", Offset = "0x10637AC", VA = "0x10637AC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x1063808", Offset = "0x1063808", VA = "0x1063808")]
	public StatusMenu_Layout()
	{
	}
}
