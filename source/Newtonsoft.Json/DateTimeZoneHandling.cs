using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public enum DateTimeZoneHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		Local,
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		Utc,
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		Unspecified,
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		RoundtripKind
	}
}
