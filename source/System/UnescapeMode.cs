using System;
using Cpp2ILInjected;

namespace System
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200008F")]
	internal enum UnescapeMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		CopyOnly = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		Escape = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		Unescape = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		EscapeUnescape = 3,
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		V1ToStringFlag = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		UnescapeAll = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		UnescapeAllOrThrow = 24
	}
}
