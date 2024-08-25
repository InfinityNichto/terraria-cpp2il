using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001E4")]
	internal enum DataParseStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A34")]
		NeedMoreData,
		[global::Cpp2ILInjected.Token(Token = "0x4000A35")]
		ContinueParsing,
		[global::Cpp2ILInjected.Token(Token = "0x4000A36")]
		Done,
		[global::Cpp2ILInjected.Token(Token = "0x4000A37")]
		Invalid,
		[global::Cpp2ILInjected.Token(Token = "0x4000A38")]
		DataTooBig
	}
}
