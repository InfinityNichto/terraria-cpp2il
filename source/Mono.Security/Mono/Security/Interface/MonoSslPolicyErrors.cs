using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	public enum MonoSslPolicyErrors
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		RemoteCertificateNotAvailable = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		RemoteCertificateNameMismatch = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		RemoteCertificateChainErrors = 4
	}
}
