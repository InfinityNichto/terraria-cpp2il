using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F3")]
public class Credits_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C86")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEAF4", Offset = "0x9CEAF4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C87")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEB40", Offset = "0x9CEB40", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Credits_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001232")]
	public static Credits_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001233")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Credits;

	[global::Cpp2ILInjected.Token(Token = "0x4001234")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
