using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000592")]
	internal enum HebrewNumberParsingState
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001779")]
		InvalidHebrewNumber,
		[global::Cpp2ILInjected.Token(Token = "0x400177A")]
		NotHebrewDigit,
		[global::Cpp2ILInjected.Token(Token = "0x400177B")]
		FoundEndOfHebrewNumber,
		[global::Cpp2ILInjected.Token(Token = "0x400177C")]
		ContinueParsing
	}
}
