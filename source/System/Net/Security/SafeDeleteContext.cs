using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Security
{
	// Token: 0x02000224 RID: 548
	[global::Cpp2ILInjected.Token(Token = "0x2000314")]
	internal abstract class SafeDeleteContext : SafeHandle
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x00006293 File Offset: 0x00004493
		[global::Cpp2ILInjected.Token(Token = "0x6001489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3780C", Offset = "0x1E3780C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeDeleteNegoContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected SafeDeleteContext(SafeFreeCredentials credential)
		{
			throw null;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00006296 File Offset: 0x00004496
		[global::Cpp2ILInjected.Token(Token = "0x170004A3")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600148A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3788C", Offset = "0x1E3788C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00006299 File Offset: 0x00004499
		[global::Cpp2ILInjected.Token(Token = "0x600148B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3789C", Offset = "0x1E3789C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		protected override bool ReleaseHandle()
		{
			throw null;
		}

		// Token: 0x04000D35 RID: 3381
		[global::Cpp2ILInjected.Token(Token = "0x4001130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SafeFreeCredentials _credential;
	}
}
