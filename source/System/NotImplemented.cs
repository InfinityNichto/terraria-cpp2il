using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000032 RID: 50
	[global::Cpp2ILInjected.Token(Token = "0x200007C")]
	internal static class NotImplemented
	{
		// Token: 0x06000158 RID: 344 RVA: 0x000031D3 File Offset: 0x000013D3
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA109C", Offset = "0x1EA109C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Exception ByDesignWithMessage(string message)
		{
			throw null;
		}
	}
}
