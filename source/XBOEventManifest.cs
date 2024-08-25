using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000049")]
public class XBOEventManifest
{
	[global::Cpp2ILInjected.Token(Token = "0x600018A")]
	[global::Cpp2ILInjected.Address(RVA = "0x705EA0", Offset = "0x705EA0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public XBOEventManifest()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600018B")]
	[global::Cpp2ILInjected.Address(RVA = "0x705EA8", Offset = "0x705EA8", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static XBOEventManifest()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000117")]
	public static string ManifestData;
}
