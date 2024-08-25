using System;
using Cpp2ILInjected;

namespace System
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200008D")]
	public enum AttributeTargets
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		Assembly = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		Module = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		Class = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		Struct = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		Enum = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		Constructor = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		Method = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		Property = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		Field = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		Event = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		Interface = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		Parameter = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		Delegate = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		ReturnValue = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		GenericParameter = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		All = 32767
	}
}
