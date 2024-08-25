using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000224")]
public class WorldName_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CDB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D09F8", Offset = "0x9D09F8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CDC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0A44", Offset = "0x9D0A44", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldName_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400155A")]
	public static WorldName_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400155B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400155C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InputWorldName;
}
