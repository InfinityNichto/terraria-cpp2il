using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public enum DateParseHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		DateTime,
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		DateTimeOffset
	}
}
