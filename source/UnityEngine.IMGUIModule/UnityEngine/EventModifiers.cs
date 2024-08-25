using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public enum EventModifiers
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		Shift = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		Control = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		Alt = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		Command = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		Numeric = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		CapsLock = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		FunctionKey = 64
	}
}
