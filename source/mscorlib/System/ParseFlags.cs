using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x0200008D RID: 141
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	internal enum ParseFlags
	{
		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		HaveYear = 1,
		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		HaveMonth = 2,
		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		HaveDay = 4,
		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		HaveHour = 8,
		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		HaveMinute = 16,
		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		HaveSecond = 32,
		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
		HaveTime = 64,
		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
		HaveDate = 128,
		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		TimeZoneUsed = 256,
		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		TimeZoneUtc = 512,
		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		ParsedMonthName = 1024,
		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		CaptureOffset = 2048,
		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		YearDefault = 4096,
		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		Rfc1123Pattern = 8192,
		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		UtcSortPattern = 16384
	}
}
