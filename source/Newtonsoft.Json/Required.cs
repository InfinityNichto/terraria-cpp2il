using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public enum Required
	{
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		AllowNull,
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		Always,
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		DisallowNull
	}
}
