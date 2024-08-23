using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000090 RID: 144
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	internal enum TokenType
	{
		// Token: 0x040001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		NumberToken = 1,
		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		YearNumberToken,
		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		Am,
		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		Pm,
		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		MonthToken,
		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		EndOfString,
		// Token: 0x040001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		DayOfWeekToken,
		// Token: 0x040001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		TimeZoneToken,
		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		EraToken,
		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		DateWordToken,
		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		UnknownToken,
		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		HebrewNumber,
		// Token: 0x040001EE RID: 494
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		JapaneseEraToken,
		// Token: 0x040001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		TEraToken,
		// Token: 0x040001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		IgnorableSymbol,
		// Token: 0x040001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		SEP_Unk = 256,
		// Token: 0x040001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		SEP_End = 512,
		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		SEP_Space = 768,
		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		SEP_Am = 1024,
		// Token: 0x040001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		SEP_Pm = 1280,
		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		SEP_Date = 1536,
		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		SEP_Time = 1792,
		// Token: 0x040001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		SEP_YearSuff = 2048,
		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		SEP_MonthSuff = 2304,
		// Token: 0x040001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		SEP_DaySuff = 2560,
		// Token: 0x040001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		SEP_HourSuff = 2816,
		// Token: 0x040001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		SEP_MinuteSuff = 3072,
		// Token: 0x040001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		SEP_SecondSuff = 3328,
		// Token: 0x040001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		SEP_LocalTimeMark = 3584,
		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		SEP_DateOrOffset = 3840,
		// Token: 0x04000200 RID: 512
		[global::Cpp2ILInjected.Token(Token = "0x400032B")]
		RegularTokenMask = 255,
		// Token: 0x04000201 RID: 513
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		SeparatorTokenMask = 65280
	}
}
