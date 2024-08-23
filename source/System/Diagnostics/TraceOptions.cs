using System;
using Cpp2ILInjected;

namespace System.Diagnostics
{
	// Token: 0x0200007B RID: 123
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	public enum TraceOptions
	{
		// Token: 0x04000278 RID: 632
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		None = 0,
		// Token: 0x04000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		LogicalOperationStack = 1,
		// Token: 0x0400027A RID: 634
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		DateTime = 2,
		// Token: 0x0400027B RID: 635
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		Timestamp = 4,
		// Token: 0x0400027C RID: 636
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		ProcessId = 8,
		// Token: 0x0400027D RID: 637
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		ThreadId = 16,
		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		Callstack = 32
	}
}
