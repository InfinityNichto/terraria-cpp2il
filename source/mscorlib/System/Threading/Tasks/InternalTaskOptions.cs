using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001BC RID: 444
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200023A")]
	internal enum InternalTaskOptions
	{
		// Token: 0x04000823 RID: 2083
		[global::Cpp2ILInjected.Token(Token = "0x4000A88")]
		None = 0,
		// Token: 0x04000824 RID: 2084
		[global::Cpp2ILInjected.Token(Token = "0x4000A89")]
		InternalOptionsMask = 65280,
		// Token: 0x04000825 RID: 2085
		[global::Cpp2ILInjected.Token(Token = "0x4000A8A")]
		ContinuationTask = 512,
		// Token: 0x04000826 RID: 2086
		[global::Cpp2ILInjected.Token(Token = "0x4000A8B")]
		PromiseTask = 1024,
		// Token: 0x04000827 RID: 2087
		[global::Cpp2ILInjected.Token(Token = "0x4000A8C")]
		LazyCancellation = 4096,
		// Token: 0x04000828 RID: 2088
		[global::Cpp2ILInjected.Token(Token = "0x4000A8D")]
		QueuedByRuntime = 8192,
		// Token: 0x04000829 RID: 2089
		[global::Cpp2ILInjected.Token(Token = "0x4000A8E")]
		DoNotDispose = 16384
	}
}
