using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000205")]
	internal static class _ThreadPoolWaitCallback
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9FF48", Offset = "0x1C9FF48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool PerformWaitCallback()
		{
			throw null;
		}
	}
}
