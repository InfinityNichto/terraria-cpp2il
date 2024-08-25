using System;
using Cpp2ILInjected;

namespace Mono.Security.X509.Extensions
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000036")]
	public enum KeyUsages
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		digitalSignature = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		nonRepudiation = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		keyEncipherment = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		dataEncipherment = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		keyAgreement = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		keyCertSign = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		cRLSign = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		encipherOnly = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		decipherOnly = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		none = 0
	}
}
