using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000126 RID: 294
	[global::Cpp2ILInjected.Token(Token = "0x20001AD")]
	internal enum IgnoreCertProblem
	{
		// Token: 0x040006B1 RID: 1713
		[global::Cpp2ILInjected.Token(Token = "0x40008CA")]
		not_time_valid = 1,
		// Token: 0x040006B2 RID: 1714
		[global::Cpp2ILInjected.Token(Token = "0x40008CB")]
		ctl_not_time_valid,
		// Token: 0x040006B3 RID: 1715
		[global::Cpp2ILInjected.Token(Token = "0x40008CC")]
		not_time_nested = 4,
		// Token: 0x040006B4 RID: 1716
		[global::Cpp2ILInjected.Token(Token = "0x40008CD")]
		invalid_basic_constraints = 8,
		// Token: 0x040006B5 RID: 1717
		[global::Cpp2ILInjected.Token(Token = "0x40008CE")]
		all_not_time_valid = 7,
		// Token: 0x040006B6 RID: 1718
		[global::Cpp2ILInjected.Token(Token = "0x40008CF")]
		allow_unknown_ca = 16,
		// Token: 0x040006B7 RID: 1719
		[global::Cpp2ILInjected.Token(Token = "0x40008D0")]
		wrong_usage = 32,
		// Token: 0x040006B8 RID: 1720
		[global::Cpp2ILInjected.Token(Token = "0x40008D1")]
		invalid_name = 64,
		// Token: 0x040006B9 RID: 1721
		[global::Cpp2ILInjected.Token(Token = "0x40008D2")]
		invalid_policy = 128,
		// Token: 0x040006BA RID: 1722
		[global::Cpp2ILInjected.Token(Token = "0x40008D3")]
		end_rev_unknown = 256,
		// Token: 0x040006BB RID: 1723
		[global::Cpp2ILInjected.Token(Token = "0x40008D4")]
		ctl_signer_rev_unknown = 512,
		// Token: 0x040006BC RID: 1724
		[global::Cpp2ILInjected.Token(Token = "0x40008D5")]
		ca_rev_unknown = 1024,
		// Token: 0x040006BD RID: 1725
		[global::Cpp2ILInjected.Token(Token = "0x40008D6")]
		root_rev_unknown = 2048,
		// Token: 0x040006BE RID: 1726
		[global::Cpp2ILInjected.Token(Token = "0x40008D7")]
		all_rev_unknown = 3840,
		// Token: 0x040006BF RID: 1727
		[global::Cpp2ILInjected.Token(Token = "0x40008D8")]
		none = 4095
	}
}
