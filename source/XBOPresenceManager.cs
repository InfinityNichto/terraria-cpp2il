using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200004B")]
public static class XBOPresenceManager
{
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000198")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F80", Offset = "0x705F80", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SetPresence(string state)
	{
		throw null;
	}
}
