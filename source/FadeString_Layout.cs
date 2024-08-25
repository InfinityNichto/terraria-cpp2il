using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001B0")]
[Serializable]
public class FadeString_Layout : String_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BBC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B26B8", Offset = "0x9B26B8", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public FadeString_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000E37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float FadeDelay;

	[global::Cpp2ILInjected.Token(Token = "0x4000E38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float FadeTime;
}
