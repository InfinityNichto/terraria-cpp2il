using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Http;

namespace System.Net
{
	// Token: 0x020001A9 RID: 425
	[global::Cpp2ILInjected.Token(Token = "0x200026B")]
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x0000591E File Offset: 0x00003B1E
		[global::Cpp2ILInjected.Token(Token = "0x600109B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03904", Offset = "0x1E03904", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticationManager), Member = "EnsureModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NtlmClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NtlmClient()
		{
			throw null;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00005921 File Offset: 0x00003B21
		[global::Cpp2ILInjected.Token(Token = "0x600109C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03968", Offset = "0x1E03968", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00005924 File Offset: 0x00003B24
		[global::Cpp2ILInjected.Token(Token = "0x600109D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03A38", Offset = "0x1E03A38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00005927 File Offset: 0x00003B27
		[global::Cpp2ILInjected.Token(Token = "0x170003B7")]
		public string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600109E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03A40", Offset = "0x1E03A40", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0000592A File Offset: 0x00003B2A
		[global::Cpp2ILInjected.Token(Token = "0x170003B8")]
		public bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600109F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03A80", Offset = "0x1E03A80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000A1D RID: 2589
		[global::Cpp2ILInjected.Token(Token = "0x4000D1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IAuthenticationModule authObject;
	}
}
