using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020B")]
public class PlayerName_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CB4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFA38", Offset = "0x9CFA38", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CB5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFA84", Offset = "0x9CFA84", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerName_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001365")]
	public static PlayerName_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001366")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001367")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InputCharacterName;
}
