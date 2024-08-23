using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x0200015E RID: 350
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20001F2")]
	internal enum ThreadKinds
	{
		// Token: 0x0400084C RID: 2124
		[global::Cpp2ILInjected.Token(Token = "0x4000A91")]
		Unknown = 0,
		// Token: 0x0400084D RID: 2125
		[global::Cpp2ILInjected.Token(Token = "0x4000A92")]
		User = 1,
		// Token: 0x0400084E RID: 2126
		[global::Cpp2ILInjected.Token(Token = "0x4000A93")]
		System = 2,
		// Token: 0x0400084F RID: 2127
		[global::Cpp2ILInjected.Token(Token = "0x4000A94")]
		Sync = 4,
		// Token: 0x04000850 RID: 2128
		[global::Cpp2ILInjected.Token(Token = "0x4000A95")]
		Async = 8,
		// Token: 0x04000851 RID: 2129
		[global::Cpp2ILInjected.Token(Token = "0x4000A96")]
		Timer = 16,
		// Token: 0x04000852 RID: 2130
		[global::Cpp2ILInjected.Token(Token = "0x4000A97")]
		CompletionPort = 32,
		// Token: 0x04000853 RID: 2131
		[global::Cpp2ILInjected.Token(Token = "0x4000A98")]
		Worker = 64,
		// Token: 0x04000854 RID: 2132
		[global::Cpp2ILInjected.Token(Token = "0x4000A99")]
		Finalization = 128,
		// Token: 0x04000855 RID: 2133
		[global::Cpp2ILInjected.Token(Token = "0x4000A9A")]
		Other = 256,
		// Token: 0x04000856 RID: 2134
		[global::Cpp2ILInjected.Token(Token = "0x4000A9B")]
		OwnerMask = 3,
		// Token: 0x04000857 RID: 2135
		[global::Cpp2ILInjected.Token(Token = "0x4000A9C")]
		SyncMask = 12,
		// Token: 0x04000858 RID: 2136
		[global::Cpp2ILInjected.Token(Token = "0x4000A9D")]
		SourceMask = 496,
		// Token: 0x04000859 RID: 2137
		[global::Cpp2ILInjected.Token(Token = "0x4000A9E")]
		SafeSources = 352,
		// Token: 0x0400085A RID: 2138
		[global::Cpp2ILInjected.Token(Token = "0x4000A9F")]
		ThreadPool = 96
	}
}
