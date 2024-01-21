using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class MaxPlayersSlider_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000E7B")]
	public TransactionButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E7C")]
	public Slider_Layout Option;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E7D")]
	public String_Layout Value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E7E")]
	public float ElementSpacing;

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x12E2D64", Offset = "0x12E2D64", VA = "0x12E2D64")]
	public MaxPlayersSlider_Layout()
	{
	}
}
