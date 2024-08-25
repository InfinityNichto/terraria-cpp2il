using System;
using System.Collections.Concurrent;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001CE")]
	internal static class PlatformHelper
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000926")]
		private static int s_processorCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000927")]
		private static int s_lastProcessorCountRefreshTicks;

		[global::Cpp2ILInjected.Token(Token = "0x4000928")]
		internal static readonly bool IsSingleProcessor;
	}
}
