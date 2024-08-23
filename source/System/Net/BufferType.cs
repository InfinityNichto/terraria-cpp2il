using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000124 RID: 292
	[global::Cpp2ILInjected.Token(Token = "0x20001AB")]
	internal enum BufferType
	{
		// Token: 0x0400069B RID: 1691
		[global::Cpp2ILInjected.Token(Token = "0x40008B4")]
		Empty,
		// Token: 0x0400069C RID: 1692
		[global::Cpp2ILInjected.Token(Token = "0x40008B5")]
		Data,
		// Token: 0x0400069D RID: 1693
		[global::Cpp2ILInjected.Token(Token = "0x40008B6")]
		Token,
		// Token: 0x0400069E RID: 1694
		[global::Cpp2ILInjected.Token(Token = "0x40008B7")]
		Parameters,
		// Token: 0x0400069F RID: 1695
		[global::Cpp2ILInjected.Token(Token = "0x40008B8")]
		Missing,
		// Token: 0x040006A0 RID: 1696
		[global::Cpp2ILInjected.Token(Token = "0x40008B9")]
		Extra,
		// Token: 0x040006A1 RID: 1697
		[global::Cpp2ILInjected.Token(Token = "0x40008BA")]
		Trailer,
		// Token: 0x040006A2 RID: 1698
		[global::Cpp2ILInjected.Token(Token = "0x40008BB")]
		Header,
		// Token: 0x040006A3 RID: 1699
		[global::Cpp2ILInjected.Token(Token = "0x40008BC")]
		Padding = 9,
		// Token: 0x040006A4 RID: 1700
		[global::Cpp2ILInjected.Token(Token = "0x40008BD")]
		Stream,
		// Token: 0x040006A5 RID: 1701
		[global::Cpp2ILInjected.Token(Token = "0x40008BE")]
		ChannelBindings = 14,
		// Token: 0x040006A6 RID: 1702
		[global::Cpp2ILInjected.Token(Token = "0x40008BF")]
		TargetHost = 16,
		// Token: 0x040006A7 RID: 1703
		[global::Cpp2ILInjected.Token(Token = "0x40008C0")]
		ReadOnlyFlag = -2147483648,
		// Token: 0x040006A8 RID: 1704
		[global::Cpp2ILInjected.Token(Token = "0x40008C1")]
		ReadOnlyWithChecksum = 268435456
	}
}
