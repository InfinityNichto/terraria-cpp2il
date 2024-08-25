using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A6")]
	public enum MaskedTextResultHint
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001287")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x4001288")]
		CharacterEscaped,
		[global::Cpp2ILInjected.Token(Token = "0x4001289")]
		NoEffect,
		[global::Cpp2ILInjected.Token(Token = "0x400128A")]
		SideEffect,
		[global::Cpp2ILInjected.Token(Token = "0x400128B")]
		Success,
		[global::Cpp2ILInjected.Token(Token = "0x400128C")]
		AsciiCharacterExpected = -1,
		[global::Cpp2ILInjected.Token(Token = "0x400128D")]
		AlphanumericCharacterExpected = -2,
		[global::Cpp2ILInjected.Token(Token = "0x400128E")]
		DigitExpected = -3,
		[global::Cpp2ILInjected.Token(Token = "0x400128F")]
		LetterExpected = -4,
		[global::Cpp2ILInjected.Token(Token = "0x4001290")]
		SignedDigitExpected = -5,
		[global::Cpp2ILInjected.Token(Token = "0x4001291")]
		InvalidInput = -51,
		[global::Cpp2ILInjected.Token(Token = "0x4001292")]
		PromptCharNotAllowed = -52,
		[global::Cpp2ILInjected.Token(Token = "0x4001293")]
		UnavailableEditPosition = -53,
		[global::Cpp2ILInjected.Token(Token = "0x4001294")]
		NonEditPosition = -54,
		[global::Cpp2ILInjected.Token(Token = "0x4001295")]
		PositionOutOfRange = -55
	}
}
