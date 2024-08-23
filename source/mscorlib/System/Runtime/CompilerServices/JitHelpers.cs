using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E6 RID: 998
	[global::Cpp2ILInjected.Token(Token = "0x200049E")]
	internal static class JitHelpers
	{
		// Token: 0x0600201E RID: 8222 RVA: 0x00019EFB File Offset: 0x000180FB
		[global::Cpp2ILInjected.Token(Token = "0x600228E")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C714", Offset = "0x158C714", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static T UnsafeCast<T>(object o) where T : class
		{
			throw null;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00019EFE File Offset: 0x000180FE
		[global::Cpp2ILInjected.Token(Token = "0x600228F")]
		[global::Cpp2ILInjected.Address(RVA = "0x158C724", Offset = "0x158C724", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static int UnsafeEnumCast<T>(T val) where T : struct
		{
			throw null;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00019F01 File Offset: 0x00018101
		[global::Cpp2ILInjected.Token(Token = "0x6002290")]
		internal static long UnsafeEnumCastLong<T>(T val) where T : struct
		{
			throw null;
		}
	}
}
