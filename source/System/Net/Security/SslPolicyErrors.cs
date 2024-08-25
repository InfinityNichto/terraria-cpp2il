using System;
using Cpp2ILInjected;

namespace System.Net.Security
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000320")]
	public enum SslPolicyErrors
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001150")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001151")]
		RemoteCertificateNotAvailable = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001152")]
		RemoteCertificateNameMismatch = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001153")]
		RemoteCertificateChainErrors = 4
	}
}
