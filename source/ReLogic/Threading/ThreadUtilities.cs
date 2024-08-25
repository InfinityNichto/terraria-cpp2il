using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B13")]
	public static class ThreadUtilities
	{
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
