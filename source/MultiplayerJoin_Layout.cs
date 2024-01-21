using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200017B")]
public class MultiplayerJoin_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E9C")]
	public static MultiplayerJoin_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E9D")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E9E")]
	public Panel_Layout Greyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E9F")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000EA0")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000EA1")]
	public String_Layout ServerIPTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000EA2")]
	public String_Layout ServerIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000EA3")]
	public String_Layout ServerIPEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000EA4")]
	public String_Layout ServerPortTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000EA5")]
	public String_Layout ServerPort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000EA6")]
	public String_Layout ServerPortEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000EA7")]
	public TransactionButton_Layout ServerIPButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000EA8")]
	public TransactionButton_Layout ServerPortButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000EA9")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000EAA")]
	public TransactionButton_Layout Join;

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x10B2708", Offset = "0x10B2708", VA = "0x10B2708")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x10B2764", Offset = "0x10B2764", VA = "0x10B2764")]
	public MultiplayerJoin_Layout()
	{
	}
}
