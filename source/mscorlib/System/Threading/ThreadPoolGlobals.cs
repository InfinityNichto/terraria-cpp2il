using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200019A RID: 410
	[global::Cpp2ILInjected.Token(Token = "0x20001FF")]
	internal static class ThreadPoolGlobals
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x00017489 File Offset: 0x00015689
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

		// Token: 0x0400078A RID: 1930
		[global::Cpp2ILInjected.Token(Token = "0x40009B4")]
		public static int processorCount;

		// Token: 0x0400078B RID: 1931
		[global::Cpp2ILInjected.Token(Token = "0x40009B5")]
		public static bool vmTpInitialized;

		// Token: 0x0400078C RID: 1932
		[global::Cpp2ILInjected.Token(Token = "0x40009B6")]
		public static bool enableWorkerTracking;

		// Token: 0x0400078D RID: 1933
		[global::Cpp2ILInjected.Token(Token = "0x40009B7")]
		public static readonly ThreadPoolWorkQueue workQueue;
	}
}
