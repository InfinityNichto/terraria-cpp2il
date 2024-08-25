using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000204")]
public class MultiplayerJoin_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF4E0", Offset = "0x9CF4E0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CA8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF52C", Offset = "0x9CF52C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerJoin_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012E0")]
	public static MultiplayerJoin_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40012E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x40012E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40012E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40012E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout ServerIPTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40012E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout ServerIP;

	[global::Cpp2ILInjected.Token(Token = "0x40012E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout ServerIPEdit;

	[global::Cpp2ILInjected.Token(Token = "0x40012E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout ServerPortTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40012E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout ServerPort;

	[global::Cpp2ILInjected.Token(Token = "0x40012EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ServerPortEdit;

	[global::Cpp2ILInjected.Token(Token = "0x40012EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ServerIPButton;

	[global::Cpp2ILInjected.Token(Token = "0x40012EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout ServerPortButton;

	[global::Cpp2ILInjected.Token(Token = "0x40012ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x40012EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Join;
}
