using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public enum StringEscapeHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		EscapeNonAscii,
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		EscapeHtml
	}
}
