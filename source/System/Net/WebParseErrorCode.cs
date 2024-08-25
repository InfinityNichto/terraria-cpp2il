using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001E7")]
	internal enum WebParseErrorCode
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A44")]
		Generic,
		[global::Cpp2ILInjected.Token(Token = "0x4000A45")]
		InvalidHeaderName,
		[global::Cpp2ILInjected.Token(Token = "0x4000A46")]
		InvalidContentLength,
		[global::Cpp2ILInjected.Token(Token = "0x4000A47")]
		IncompleteHeaderLine,
		[global::Cpp2ILInjected.Token(Token = "0x4000A48")]
		CrLfError,
		[global::Cpp2ILInjected.Token(Token = "0x4000A49")]
		InvalidChunkFormat,
		[global::Cpp2ILInjected.Token(Token = "0x4000A4A")]
		UnexpectedServerResponse
	}
}
