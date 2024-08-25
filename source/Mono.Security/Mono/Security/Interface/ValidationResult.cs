using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	public class ValidationResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B374", Offset = "0x1A9B374", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(ref X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public bool Trusted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3BC", Offset = "0x1A9B3BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public bool UserDenied
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3C4", Offset = "0x1A9B3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool trusted;

		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool user_denied;

		[global::Cpp2ILInjected.Token(Token = "0x4000118")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int error_code;

		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MonoSslPolicyErrors? policy_errors;
	}
}
