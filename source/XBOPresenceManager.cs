using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200002D RID: 45
[global::Cpp2ILInjected.Token(Token = "0x200004B")]
public static class XBOPresenceManager
{
	// Token: 0x06000116 RID: 278 RVA: 0x00021EBA File Offset: 0x000200BA
	[Conditional("UNITY_XBOXONE")]
	[global::Cpp2ILInjected.Token(Token = "0x6000198")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F80", Offset = "0x705F80", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void SetPresence(string state)
	{
		throw null;
	}
}
