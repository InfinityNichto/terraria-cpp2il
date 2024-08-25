using System;
using Cpp2ILInjected;

namespace Mono.Security.Protocol.Ntlm
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	public enum NtlmFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		NegotiateUnicode = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		NegotiateOem = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		RequestTarget = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		NegotiateNtlm = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		NegotiateDomainSupplied = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		NegotiateWorkstationSupplied = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		NegotiateAlwaysSign = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		NegotiateNtlm2Key = 524288,
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		Negotiate128 = 536870912,
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		Negotiate56 = -2147483648
	}
}
