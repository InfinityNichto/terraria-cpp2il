using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Security
{
	// Token: 0x02000221 RID: 545
	[global::Cpp2ILInjected.Token(Token = "0x2000311")]
	internal static class SSPIHandleCache
	{
		// Token: 0x06001248 RID: 4680 RVA: 0x00006284 File Offset: 0x00004484
		[global::Cpp2ILInjected.Token(Token = "0x6001484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3739C", Offset = "0x1E3739C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeCredentialReference), Member = "CreateReference", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(SafeCredentialReference))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CriticalHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionCheck), Member = "IsFatal", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static void CacheCredential(SafeFreeCredentials newHandle)
		{
			throw null;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00006287 File Offset: 0x00004487
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37588", Offset = "0x1E37588", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SSPIHandleCache()
		{
			throw null;
		}

		// Token: 0x04000D1D RID: 3357
		[global::Cpp2ILInjected.Token(Token = "0x4001118")]
		private static SafeCredentialReference[] s_cacheSlots;

		// Token: 0x04000D1E RID: 3358
		[global::Cpp2ILInjected.Token(Token = "0x4001119")]
		private static int s_current;
	}
}
