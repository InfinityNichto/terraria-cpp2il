using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016C")]
public class DeletePlayer_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DF8")]
	public static DeletePlayer_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DF9")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DFA")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DFB")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DFC")]
	public StringButton_Layout DeletePrompt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000DFD")]
	public TransactionButton_Layout Yes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000DFE")]
	public TransactionButton_Layout No;

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x20C9AB8", Offset = "0x20C9AB8", VA = "0x20C9AB8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x20C9B14", Offset = "0x20C9B14", VA = "0x20C9B14")]
	public DeletePlayer_Layout()
	{
	}
}
