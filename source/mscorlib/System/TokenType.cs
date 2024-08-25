using System;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	internal enum TokenType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		NumberToken = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		YearNumberToken,
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		Am,
		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		Pm,
		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		MonthToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		EndOfString,
		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		DayOfWeekToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		TimeZoneToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		EraToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		DateWordToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		UnknownToken,
		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		HebrewNumber,
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		JapaneseEraToken,
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		TEraToken,
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		IgnorableSymbol,
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		SEP_Unk = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		SEP_End = 512,
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		SEP_Space = 768,
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		SEP_Am = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		SEP_Pm = 1280,
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		SEP_Date = 1536,
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		SEP_Time = 1792,
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		SEP_YearSuff = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		SEP_MonthSuff = 2304,
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		SEP_DaySuff = 2560,
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		SEP_HourSuff = 2816,
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		SEP_MinuteSuff = 3072,
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		SEP_SecondSuff = 3328,
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		SEP_LocalTimeMark = 3584,
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		SEP_DateOrOffset = 3840,
		[global::Cpp2ILInjected.Token(Token = "0x400032B")]
		RegularTokenMask = 255,
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		SeparatorTokenMask = 65280
	}
}
