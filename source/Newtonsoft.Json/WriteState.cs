using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	public enum WriteState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		Error,
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		Closed,
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		Object,
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		Array,
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		Constructor,
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		Property,
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		Start
	}
}
