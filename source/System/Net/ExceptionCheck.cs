using System;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C4 RID: 196
	[global::Cpp2ILInjected.Token(Token = "0x2000125")]
	internal static class ExceptionCheck
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x00003FFB File Offset: 0x000021FB
		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0BD8", Offset = "0x1EE0BD8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SSPIHandleCache), Member = "CacheCredential", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsFatal(Exception exception)
		{
			throw null;
		}
	}
}
