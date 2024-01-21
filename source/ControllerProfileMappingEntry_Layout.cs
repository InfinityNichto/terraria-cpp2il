using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200012C")]
public class ControllerProfileMappingEntry_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A28")]
	public TransactionButton_Layout PulldownButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A29")]
	public TransactionButton_Layout IconTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A2A")]
	public Panel_Layout PulldownGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A2B")]
	public TransactionButton_Layout Action;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A2C")]
	public TransactionButton_Layout ActionMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A2D")]
	public String_Layout Unbound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A2E")]
	public String_Layout Bound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A2F")]
	public TransactionButton_Layout Cancel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A30")]
	public TransactionButton_Layout ClearBinding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A31")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x120FFC8", Offset = "0x120FFC8", VA = "0x120FFC8")]
	public ControllerProfileMappingEntry_Layout()
	{
	}
}
