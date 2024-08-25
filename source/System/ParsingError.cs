using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200008E")]
	internal enum ParsingError
	{
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		BadFormat,
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		BadScheme,
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		BadAuthority,
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		EmptyUriString,
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		LastRelativeUriOkErrIndex = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		SchemeLimit,
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		SizeLimit,
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		MustRootedPath,
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		BadHostName,
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		NonEmptyHost,
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		BadPort,
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		BadAuthorityTerminator,
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		CannotCreateRelative
	}
}
