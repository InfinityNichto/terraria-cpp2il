using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016D")]
public class DeleteWorld_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DFF")]
	public static DeleteWorld_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E00")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E01")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E02")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000E03")]
	public StringButton_Layout DeletePrompt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000E04")]
	public TransactionButton_Layout Yes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000E05")]
	public TransactionButton_Layout No;

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x20C9B90", Offset = "0x20C9B90", VA = "0x20C9B90")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x20C9BEC", Offset = "0x20C9BEC", VA = "0x20C9BEC")]
	public DeleteWorld_Layout()
	{
	}
}
