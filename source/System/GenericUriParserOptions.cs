using System;
using Cpp2ILInjected;

namespace System
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	public enum GenericUriParserOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		Default = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		GenericAuthority = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		AllowEmptyAuthority = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		NoUserInfo = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		NoPort = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		NoQuery = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		NoFragment = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		DontConvertPathBackslashes = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		DontCompressPath = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		DontUnescapePathDotsAndSlashes = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		Idn = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		IriParsing = 1024
	}
}
