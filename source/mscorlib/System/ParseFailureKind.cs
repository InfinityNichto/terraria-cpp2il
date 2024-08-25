using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
	internal enum ParseFailureKind
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		ArgumentNull,
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		Format,
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		FormatWithParameter,
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		FormatWithOriginalDateTime,
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		FormatWithFormatSpecifier,
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		FormatWithOriginalDateTimeAndParameter,
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		FormatBadDateTimeCalendar
	}
}
