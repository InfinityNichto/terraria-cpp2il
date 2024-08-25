using System;
using System.Diagnostics.Tracing;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Concurrent
{
	[global::System.Diagnostics.Tracing.EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
	[global::Cpp2ILInjected.Token(Token = "0x2000615")]
	internal sealed class CDSCollectionETWBCLProvider : global::System.Diagnostics.Tracing.EventSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14EE0", Offset = "0x1C14EE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = ".ctor", ReturnType = typeof(void))]
		private CDSCollectionETWBCLProvider()
		{
			throw null;
		}

		[global::System.Diagnostics.Tracing.Event(3, Level = global::System.Diagnostics.Tracing.EventLevel.Warning)]
		[global::Cpp2ILInjected.Token(Token = "0x6002F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14EE4", Offset = "0x1C14EE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConcurrentDictionary<, >), Member = "AcquireAllLocks", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002F79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C14EE8", Offset = "0x1C14EE8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Tracing.EventSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static CDSCollectionETWBCLProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A2A")]
		public static CDSCollectionETWBCLProvider Log;
	}
}
