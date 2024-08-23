using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000225 RID: 549
	[global::Cpp2ILInjected.Token(Token = "0x2000315")]
	internal sealed class SafeDeleteNegoContext : SafeDeleteContext
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0000629C File Offset: 0x0000449C
		[global::Cpp2ILInjected.Token(Token = "0x170004A4")]
		public SafeGssNameHandle TargetName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E378C0", Offset = "0x1E378C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0000629F File Offset: 0x0000449F
		[global::Cpp2ILInjected.Token(Token = "0x170004A5")]
		public bool IsNtlmUsed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E378C8", Offset = "0x1E378C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x000062A2 File Offset: 0x000044A2
		[global::Cpp2ILInjected.Token(Token = "0x170004A6")]
		public SafeGssContextHandle GssContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E378D0", Offset = "0x1E378D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000062A5 File Offset: 0x000044A5
		[global::Cpp2ILInjected.Token(Token = "0x600148F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3686C", Offset = "0x1E3686C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeDeleteContext), Member = ".ctor", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeGssNameHandle), Member = "CreatePrincipal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public SafeDeleteNegoContext(SafeFreeNegoCredentials credential, string targetName)
		{
			throw null;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000062A8 File Offset: 0x000044A8
		[global::Cpp2ILInjected.Token(Token = "0x6001490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E378D8", Offset = "0x1E378D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetGssContext(SafeGssContextHandle context)
		{
			throw null;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000062AB File Offset: 0x000044AB
		[global::Cpp2ILInjected.Token(Token = "0x6001491")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E378E0", Offset = "0x1E378E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetAuthenticationPackage(bool isNtlmUsed)
		{
			throw null;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000062AE File Offset: 0x000044AE
		[global::Cpp2ILInjected.Token(Token = "0x6001492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E378EC", Offset = "0x1E378EC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x04000D36 RID: 3382
		[global::Cpp2ILInjected.Token(Token = "0x4001131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SafeGssNameHandle _targetName;

		// Token: 0x04000D37 RID: 3383
		[global::Cpp2ILInjected.Token(Token = "0x4001132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SafeGssContextHandle _context;

		// Token: 0x04000D38 RID: 3384
		[global::Cpp2ILInjected.Token(Token = "0x4001133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _isNtlmUsed;
	}
}
