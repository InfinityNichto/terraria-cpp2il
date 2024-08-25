using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000159")]
	public enum SecurityProtocolType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40006FC")]
		SystemDefault = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40006FD")]
		Ssl3 = 48,
		[global::Cpp2ILInjected.Token(Token = "0x40006FE")]
		Tls = 192,
		[global::Cpp2ILInjected.Token(Token = "0x40006FF")]
		Tls11 = 768,
		[global::Cpp2ILInjected.Token(Token = "0x4000700")]
		Tls12 = 3072,
		[global::Cpp2ILInjected.Token(Token = "0x4000701")]
		Tls13 = 12288
	}
}
