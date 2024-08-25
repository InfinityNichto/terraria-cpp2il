using System;
using Cpp2ILInjected;

namespace System
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200008B")]
	public enum UriComponents
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		Scheme = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		UserInfo = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		Host = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		Port = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		Path = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		Query = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		Fragment = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		StrongPort = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		NormalizedHost = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		KeepDelimiter = 1073741824,
		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		SerializationInfoString = -2147483648,
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		AbsoluteUri = 127,
		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		HostAndPort = 132,
		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		StrongAuthority = 134,
		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		SchemeAndServer = 13,
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		HttpRequestUrl = 61,
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		PathAndQuery = 48
	}
}
