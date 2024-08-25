using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	internal enum JsonContainerType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		Object,
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		Array,
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		Constructor
	}
}
