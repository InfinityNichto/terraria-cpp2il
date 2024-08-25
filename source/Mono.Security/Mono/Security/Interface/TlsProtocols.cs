using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000050")]
	public enum TlsProtocols
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		Zero = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		Tls10Client = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		Tls10Server = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		Tls10 = 192,
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		Tls11Client = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		Tls11Server = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		Tls11 = 768,
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		Tls12Client = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		Tls12Server = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		Tls12 = 3072,
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		ClientMask = 2688,
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		ServerMask = 1344
	}
}
