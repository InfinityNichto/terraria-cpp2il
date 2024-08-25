using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000095")]
	public enum TouchScreenKeyboardType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x4000339")]
		ASCIICapable,
		[global::Cpp2ILInjected.Token(Token = "0x400033A")]
		NumbersAndPunctuation,
		[global::Cpp2ILInjected.Token(Token = "0x400033B")]
		URL,
		[global::Cpp2ILInjected.Token(Token = "0x400033C")]
		NumberPad,
		[global::Cpp2ILInjected.Token(Token = "0x400033D")]
		PhonePad,
		[global::Cpp2ILInjected.Token(Token = "0x400033E")]
		NamePhonePad,
		[global::Cpp2ILInjected.Token(Token = "0x400033F")]
		EmailAddress,
		[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000340")]
		NintendoNetworkAccount,
		[global::Cpp2ILInjected.Token(Token = "0x4000341")]
		Social,
		[global::Cpp2ILInjected.Token(Token = "0x4000342")]
		Search,
		[global::Cpp2ILInjected.Token(Token = "0x4000343")]
		DecimalPad,
		[global::Cpp2ILInjected.Token(Token = "0x4000344")]
		OneTimeCode
	}
}
