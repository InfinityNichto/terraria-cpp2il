using System;
using Cpp2ILInjected;

namespace System
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	internal enum ParseFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		HaveYear = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		HaveMonth = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		HaveDay = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		HaveHour = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		HaveMinute = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		HaveSecond = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
		HaveTime = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
		HaveDate = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		TimeZoneUsed = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		TimeZoneUtc = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		ParsedMonthName = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		CaptureOffset = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		YearDefault = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		Rfc1123Pattern = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		UtcSortPattern = 16384
	}
}
