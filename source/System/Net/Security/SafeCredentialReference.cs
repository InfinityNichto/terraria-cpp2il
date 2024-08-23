using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000227 RID: 551
	[global::Cpp2ILInjected.Token(Token = "0x2000317")]
	internal sealed class SafeCredentialReference : CriticalHandleMinusOneIsInvalid
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x000062B4 File Offset: 0x000044B4
		[global::Cpp2ILInjected.Token(Token = "0x6001494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3751C", Offset = "0x1E3751C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SSPIHandleCache), Member = "CacheCredential", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeCredentialReference), Member = ".ctor", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static SafeCredentialReference CreateReference(SafeFreeCredentials target)
		{
			throw null;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000062B7 File Offset: 0x000044B7
		[global::Cpp2ILInjected.Token(Token = "0x6001495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3794C", Offset = "0x1E3794C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeCredentialReference), Member = "CreateReference", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(SafeCredentialReference))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CriticalHandleMinusOneIsInvalid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private SafeCredentialReference(SafeFreeCredentials target)
		{
			throw null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000062BA File Offset: 0x000044BA
		[global::Cpp2ILInjected.Token(Token = "0x6001496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E379AC", Offset = "0x1E379AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		protected override bool ReleaseHandle()
		{
			throw null;
		}

		// Token: 0x04000D39 RID: 3385
		[global::Cpp2ILInjected.Token(Token = "0x4001134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal SafeFreeCredentials Target;
	}
}
