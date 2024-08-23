using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Threading
{
	// Token: 0x02000719 RID: 1817
	[global::Cpp2ILInjected.Token(Token = "0x2000B13")]
	public static class ThreadUtilities
	{
		// Token: 0x0600466F RID: 18031 RVA: 0x0002E9B5 File Offset: 0x0002CBB5
		[global::Cpp2ILInjected.Token(Token = "0x6005318")]
		[global::Cpp2ILInjected.Address(RVA = "0x940E88", Offset = "0x940E88", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "GetTimestamp", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void HighPrecisionSleep(double timeInMs)
		{
			throw null;
		}
	}
}
