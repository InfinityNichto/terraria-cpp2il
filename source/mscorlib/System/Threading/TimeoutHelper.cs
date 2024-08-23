using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200017C RID: 380
	[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
	internal static class TimeoutHelper
	{
		// Token: 0x06000FCC RID: 4044 RVA: 0x000171B9 File Offset: 0x000153B9
		[global::Cpp2ILInjected.Token(Token = "0x6001101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C95D64", Offset = "0x1C95D64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		public static uint GetTime()
		{
			throw null;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000171BC File Offset: 0x000153BC
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
