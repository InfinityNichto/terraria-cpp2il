using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200000E RID: 14
	[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public enum ProcessingState
	{
		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Unknown,
		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		InQueue,
		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		Reading,
		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		Completed,
		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		Failed,
		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		Canceled
	}
}
