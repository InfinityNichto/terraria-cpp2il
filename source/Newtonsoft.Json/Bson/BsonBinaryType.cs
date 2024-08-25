using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200011E")]
	internal enum BsonBinaryType : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		Binary,
		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		Function,
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		BinaryOld,
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		UuidOld,
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		Uuid,
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		Md5,
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		UserDefined = 128
	}
}
