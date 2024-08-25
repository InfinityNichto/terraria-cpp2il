using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200049E")]
	internal static class JitHelpers
	{
		[global::Cpp2ILInjected.Token(Token = "0x600228E")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C714", Offset = "0x158C714", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static T UnsafeCast<T>(object o) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600228F")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C724", Offset = "0x158C724", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static int UnsafeEnumCast<T>(T val) where T : struct
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002290")]
		internal static long UnsafeEnumCastLong<T>(T val) where T : struct
		{
			throw null;
		}
	}
}
