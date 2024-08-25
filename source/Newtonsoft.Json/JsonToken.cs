using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	public enum JsonToken
	{
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		StartObject,
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		StartArray,
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		StartConstructor,
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		PropertyName,
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		Comment,
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		Raw,
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		Integer,
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		Float,
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		String,
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		Boolean,
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		Null,
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		Undefined,
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		EndObject,
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		EndArray,
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		EndConstructor,
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		Date,
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		Bytes
	}
}
