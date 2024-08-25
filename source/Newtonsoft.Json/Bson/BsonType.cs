using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012B")]
	internal enum BsonType : sbyte
	{
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		Number = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		String,
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		Object,
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		Array,
		[global::Cpp2ILInjected.Token(Token = "0x400045E")]
		Binary,
		[global::Cpp2ILInjected.Token(Token = "0x400045F")]
		Undefined,
		[global::Cpp2ILInjected.Token(Token = "0x4000460")]
		Oid,
		[global::Cpp2ILInjected.Token(Token = "0x4000461")]
		Boolean,
		[global::Cpp2ILInjected.Token(Token = "0x4000462")]
		Date,
		[global::Cpp2ILInjected.Token(Token = "0x4000463")]
		Null,
		[global::Cpp2ILInjected.Token(Token = "0x4000464")]
		Regex,
		[global::Cpp2ILInjected.Token(Token = "0x4000465")]
		Reference,
		[global::Cpp2ILInjected.Token(Token = "0x4000466")]
		Code,
		[global::Cpp2ILInjected.Token(Token = "0x4000467")]
		Symbol,
		[global::Cpp2ILInjected.Token(Token = "0x4000468")]
		CodeWScope,
		[global::Cpp2ILInjected.Token(Token = "0x4000469")]
		Integer,
		[global::Cpp2ILInjected.Token(Token = "0x400046A")]
		TimeStamp,
		[global::Cpp2ILInjected.Token(Token = "0x400046B")]
		Long,
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		MinKey = -1,
		[global::Cpp2ILInjected.Token(Token = "0x400046D")]
		MaxKey = 127
	}
}
