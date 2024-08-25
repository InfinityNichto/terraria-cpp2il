using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	public enum ReferenceLoopHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		Error,
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		Ignore,
		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		Serialize
	}
}
