using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016B")]
public class DeleteDedicatedServer_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DF1")]
	public static DeleteDedicatedServer_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DF2")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DF3")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DF4")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DF5")]
	public StringButton_Layout DeletePrompt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000DF6")]
	public TransactionButton_Layout Yes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000DF7")]
	public TransactionButton_Layout No;

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x20C99E0", Offset = "0x20C99E0", VA = "0x20C99E0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x20C9A3C", Offset = "0x20C9A3C", VA = "0x20C9A3C")]
	public DeleteDedicatedServer_Layout()
	{
	}
}
