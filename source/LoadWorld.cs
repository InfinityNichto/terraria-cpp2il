using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class LoadWorld
{
	[Cpp2IlInjected.Token(Token = "0x4000E54")]
	public static LoadWorld Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000E55")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E56")]
	public TransactionButton_Layout Load;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E57")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x12DB79C", Offset = "0x12DB79C", VA = "0x12DB79C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x12DB7F8", Offset = "0x12DB7F8", VA = "0x12DB7F8")]
	public LoadWorld()
	{
	}
}
