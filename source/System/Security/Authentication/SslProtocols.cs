using System;
using Cpp2ILInjected;

namespace System.Security.Authentication
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	public enum SslProtocols
	{
		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400042F")]
		Ssl2 = 12,
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		Ssl3 = 48,
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		Tls = 192,
		[MonoTODO("unsupported")]
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		Tls11 = 768,
		[MonoTODO("unsupported")]
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		Tls12 = 3072,
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		Tls13 = 12288,
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		Default = 240
	}
}
