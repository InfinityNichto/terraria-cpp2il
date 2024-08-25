using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000028")]
	internal enum ReadType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		Read,
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		ReadAsInt32,
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		ReadAsBytes,
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		ReadAsString,
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		ReadAsDecimal,
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		ReadAsDateTime,
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		ReadAsDateTimeOffset,
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		ReadAsDouble,
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		ReadAsBoolean
	}
}
