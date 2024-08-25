using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004E2")]
	public enum ParameterAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40013ED")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013EE")]
		In = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40013EF")]
		Out = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40013F0")]
		Lcid = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40013F1")]
		Retval = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40013F2")]
		Optional = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40013F3")]
		HasDefault = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40013F4")]
		HasFieldMarshal = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40013F5")]
		Reserved3 = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x40013F6")]
		Reserved4 = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x40013F7")]
		ReservedMask = 61440
	}
}
