using System;
using System.Collections.Concurrent;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200017B RID: 379
	[global::Cpp2ILInjected.Token(Token = "0x20001CE")]
	internal static class PlatformHelper
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000171B3 File Offset: 0x000153B3
		[global::Cpp2ILInjected.Token(Token = "0x17000190")]
		internal static int ProcessorCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9640C", Offset = "0x1C9640C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformHelper), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "get_DefaultConcurrencyLevel", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_TickCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000171B6 File Offset: 0x000153B6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C964F8", Offset = "0x1C964F8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlatformHelper()
		{
			throw null;
		}

		// Token: 0x04000725 RID: 1829
		[global::Cpp2ILInjected.Token(Token = "0x4000926")]
		private static int s_processorCount;

		// Token: 0x04000726 RID: 1830
		[global::Cpp2ILInjected.Token(Token = "0x4000927")]
		private static int s_lastProcessorCountRefreshTicks;

		// Token: 0x04000727 RID: 1831
		[global::Cpp2ILInjected.Token(Token = "0x4000928")]
		internal static readonly bool IsSingleProcessor;
	}
}
