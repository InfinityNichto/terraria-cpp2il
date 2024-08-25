using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004DB")]
	public enum MemberTypes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40013B4")]
		Constructor = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40013B5")]
		Event = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40013B6")]
		Field = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40013B7")]
		Method = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40013B8")]
		Property = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40013B9")]
		TypeInfo = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40013BA")]
		Custom = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40013BB")]
		NestedType = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40013BC")]
		All = 191
	}
}
