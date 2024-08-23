using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	// Token: 0x02000228 RID: 552
	[global::Cpp2ILInjected.Token(Token = "0x2000318")]
	internal sealed class SafeFreeNegoCredentials : SafeFreeCredentials
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000062BD File Offset: 0x000044BD
		[global::Cpp2ILInjected.Token(Token = "0x170004A7")]
		public SafeGssCredHandle GssCredential
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001497")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E379D4", Offset = "0x1E379D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000062C0 File Offset: 0x000044C0
		[global::Cpp2ILInjected.Token(Token = "0x170004A8")]
		public bool IsNtlmOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001498")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E379DC", Offset = "0x1E379DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000062C3 File Offset: 0x000044C3
		[global::Cpp2ILInjected.Token(Token = "0x170004A9")]
		public string UserName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001499")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E379E4", Offset = "0x1E379E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000062C6 File Offset: 0x000044C6
		[global::Cpp2ILInjected.Token(Token = "0x170004AA")]
		public bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E379EC", Offset = "0x1E379EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000062C9 File Offset: 0x000044C9
		[global::Cpp2ILInjected.Token(Token = "0x600149B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36EEC", Offset = "0x1E36EEC", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(NetworkCredential)
		}, ReturnType = typeof(SafeFreeCredentials))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeGssCredHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SafeFreeNegoCredentials(bool isNtlmOnly, string username, string password, string domain)
		{
			throw null;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x000062CC File Offset: 0x000044CC
		[global::Cpp2ILInjected.Token(Token = "0x170004AB")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600149C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E379F4", Offset = "0x1E379F4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000062CF File Offset: 0x000044CF
		[global::Cpp2ILInjected.Token(Token = "0x600149D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37A04", Offset = "0x1E37A04", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		protected override bool ReleaseHandle()
		{
			throw null;
		}

		// Token: 0x04000D3A RID: 3386
		[global::Cpp2ILInjected.Token(Token = "0x4001135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SafeGssCredHandle _credential;

		// Token: 0x04000D3B RID: 3387
		[global::Cpp2ILInjected.Token(Token = "0x4001136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly bool _isNtlmOnly;

		// Token: 0x04000D3C RID: 3388
		[global::Cpp2ILInjected.Token(Token = "0x4001137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly string _userName;

		// Token: 0x04000D3D RID: 3389
		[global::Cpp2ILInjected.Token(Token = "0x4001138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly bool _isDefault;
	}
}
