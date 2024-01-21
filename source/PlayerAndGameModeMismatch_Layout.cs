using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000180")]
public class PlayerAndGameModeMismatch_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000EE3")]
	public static PlayerAndGameModeMismatch_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000EE4")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000EE5")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000EE6")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000EE7")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000EE8")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000EE9")]
	public String_Layout GameTip;

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x10B6A84", Offset = "0x10B6A84", VA = "0x10B6A84")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x10B6AE0", Offset = "0x10B6AE0", VA = "0x10B6AE0")]
	public PlayerAndGameModeMismatch_Layout()
	{
	}
}
