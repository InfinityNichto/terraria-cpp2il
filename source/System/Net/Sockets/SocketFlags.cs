using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000211 RID: 529
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000300")]
	public enum SocketFlags
	{
		// Token: 0x04000C8D RID: 3213
		[global::Cpp2ILInjected.Token(Token = "0x4001086")]
		None = 0,
		// Token: 0x04000C8E RID: 3214
		[global::Cpp2ILInjected.Token(Token = "0x4001087")]
		OutOfBand = 1,
		// Token: 0x04000C8F RID: 3215
		[global::Cpp2ILInjected.Token(Token = "0x4001088")]
		Peek = 2,
		// Token: 0x04000C90 RID: 3216
		[global::Cpp2ILInjected.Token(Token = "0x4001089")]
		DontRoute = 4,
		// Token: 0x04000C91 RID: 3217
		[global::Cpp2ILInjected.Token(Token = "0x400108A")]
		MaxIOVectorLength = 16,
		// Token: 0x04000C92 RID: 3218
		[global::Cpp2ILInjected.Token(Token = "0x400108B")]
		Truncated = 256,
		// Token: 0x04000C93 RID: 3219
		[global::Cpp2ILInjected.Token(Token = "0x400108C")]
		ControlDataTruncated = 512,
		// Token: 0x04000C94 RID: 3220
		[global::Cpp2ILInjected.Token(Token = "0x400108D")]
		Broadcast = 1024,
		// Token: 0x04000C95 RID: 3221
		[global::Cpp2ILInjected.Token(Token = "0x400108E")]
		Multicast = 2048,
		// Token: 0x04000C96 RID: 3222
		[global::Cpp2ILInjected.Token(Token = "0x400108F")]
		Partial = 32768
	}
}
