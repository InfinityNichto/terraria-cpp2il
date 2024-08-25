using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000099")]
	internal enum JsonContractType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		Object,
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		Array,
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		Primitive,
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		String,
		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		Dictionary,
		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		Dynamic,
		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		Serializable,
		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		Linq
	}
}
