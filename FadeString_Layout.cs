using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000135")]
public class FadeString_Layout : String_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000A80")]
	public float FadeDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000A81")]
	public float FadeTime;

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x20D2914", Offset = "0x20D2914", VA = "0x20D2914")]
	public FadeString_Layout()
	{
	}
}
