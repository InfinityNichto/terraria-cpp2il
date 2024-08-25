using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[AttributeUsage(AttributeTargets.All)]
[global::Cpp2ILInjected.Token(Token = "0x2000062")]
public class ResourceLocationAttribute : Attribute
{
	[global::Cpp2ILInjected.Token(Token = "0x6000208")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B314", Offset = "0x70B314", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public ResourceLocationAttribute(string location)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly string Location;
}
