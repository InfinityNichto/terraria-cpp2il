using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
	internal enum QueryOperator
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		Equals,
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		NotEquals,
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		Exists,
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		LessThan,
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		LessThanOrEquals,
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		GreaterThan,
		[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
		GreaterThanOrEquals,
		[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
		And,
		[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
		Or
	}
}
