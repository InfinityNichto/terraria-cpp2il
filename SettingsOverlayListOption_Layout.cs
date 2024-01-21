using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class SettingsOverlayListOption_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000F95")]
	public TransactionButton_Layout Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F96")]
	public TransactionButton_Layout Caption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F97")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0xFA78D0", Offset = "0xFA78D0", VA = "0xFA78D0")]
	public SettingsOverlayListOption_Layout()
	{
	}
}
