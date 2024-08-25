using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
	internal static class TimeoutHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95D64", Offset = "0x1C95D64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		public static uint GetTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95E14", Offset = "0x1C95E14", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			throw null;
		}
	}
}
