using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000202")]
[Serializable]
public class MaxPlayersSlider_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF434", Offset = "0x9CF434", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public MaxPlayersSlider_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40012C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Slider_Layout Option;

	[global::Cpp2ILInjected.Token(Token = "0x40012C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Value;

	[global::Cpp2ILInjected.Token(Token = "0x40012C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ElementSpacing;
}
