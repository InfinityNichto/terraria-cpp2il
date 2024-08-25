using System;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000168")]
	internal enum XsdDateTimeFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		DateTime = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		Time = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		Date = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		GYearMonth = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		GYear = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		GMonthDay = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000637")]
		GDay = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		GMonth = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000639")]
		XdrDateTimeNoTz = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400063A")]
		XdrDateTime = 512,
		[global::Cpp2ILInjected.Token(Token = "0x400063B")]
		XdrTimeNoTz = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x400063C")]
		AllXsd = 255
	}
}
