using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001AF")]
	internal enum CertificateEncoding
	{
		[global::Cpp2ILInjected.Token(Token = "0x40008DD")]
		Zero,
		[global::Cpp2ILInjected.Token(Token = "0x40008DE")]
		X509AsnEncoding,
		[global::Cpp2ILInjected.Token(Token = "0x40008DF")]
		X509NdrEncoding,
		[global::Cpp2ILInjected.Token(Token = "0x40008E0")]
		Pkcs7AsnEncoding = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x40008E1")]
		Pkcs7NdrEncoding = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x40008E2")]
		AnyAsnEncoding = 65537
	}
}
