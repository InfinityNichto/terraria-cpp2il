using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000129")]
public class ControllerMappingEntry_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A06")]
	public TransactionButton_Layout PulldownButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A07")]
	public String_Layout PulldownTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A08")]
	public Panel_Layout PulldownGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A09")]
	public TransactionButton_Layout Action;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A0A")]
	public TransactionButton_Layout ActionMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A0B")]
	public String_Layout Unbound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A0C")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A0D")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x120DA1C", Offset = "0x120DA1C", VA = "0x120DA1C")]
	public ControllerMappingEntry_Layout()
	{
	}
}
