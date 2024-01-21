using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000186")]
public class ResetSettings_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000F5A")]
	public static ResetSettings_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F5B")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F5C")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000F5D")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000F5E")]
	public StringButton_Layout DeletePrompt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000F5F")]
	public TransactionButton_Layout Yes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000F60")]
	public TransactionButton_Layout No;

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0xF99814", Offset = "0xF99814", VA = "0xF99814")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0xF99870", Offset = "0xF99870", VA = "0xF99870")]
	public ResetSettings_Layout()
	{
	}
}
