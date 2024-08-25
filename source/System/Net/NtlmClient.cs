using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Http;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200026B")]
	internal class NtlmClient : IAuthenticationModule
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600109C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03968", Offset = "0x1E03968", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600109D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03A38", Offset = "0x1E03A38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000D1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IAuthenticationModule authObject;
	}
}
