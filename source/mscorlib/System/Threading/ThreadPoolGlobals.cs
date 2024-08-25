using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001FF")]
	internal static class ThreadPoolGlobals
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9E4E8", Offset = "0x1C9E4E8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPoolWorkQueue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ThreadPoolGlobals()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009B4")]
		public static int processorCount;

		[global::Cpp2ILInjected.Token(Token = "0x40009B5")]
		public static bool vmTpInitialized;

		[global::Cpp2ILInjected.Token(Token = "0x40009B6")]
		public static bool enableWorkerTracking;

		[global::Cpp2ILInjected.Token(Token = "0x40009B7")]
		public static readonly ThreadPoolWorkQueue workQueue;
	}
}
