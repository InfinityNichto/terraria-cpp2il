using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001BD RID: 445
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200023B")]
	public enum TaskContinuationOptions
	{
		// Token: 0x0400082B RID: 2091
		[global::Cpp2ILInjected.Token(Token = "0x4000A90")]
		None = 0,
		// Token: 0x0400082C RID: 2092
		[global::Cpp2ILInjected.Token(Token = "0x4000A91")]
		PreferFairness = 1,
		// Token: 0x0400082D RID: 2093
		[global::Cpp2ILInjected.Token(Token = "0x4000A92")]
		LongRunning = 2,
		// Token: 0x0400082E RID: 2094
		[global::Cpp2ILInjected.Token(Token = "0x4000A93")]
		AttachedToParent = 4,
		// Token: 0x0400082F RID: 2095
		[global::Cpp2ILInjected.Token(Token = "0x4000A94")]
		DenyChildAttach = 8,
		// Token: 0x04000830 RID: 2096
		[global::Cpp2ILInjected.Token(Token = "0x4000A95")]
		HideScheduler = 16,
		// Token: 0x04000831 RID: 2097
		[global::Cpp2ILInjected.Token(Token = "0x4000A96")]
		LazyCancellation = 32,
		// Token: 0x04000832 RID: 2098
		[global::Cpp2ILInjected.Token(Token = "0x4000A97")]
		RunContinuationsAsynchronously = 64,
		// Token: 0x04000833 RID: 2099
		[global::Cpp2ILInjected.Token(Token = "0x4000A98")]
		NotOnRanToCompletion = 65536,
		// Token: 0x04000834 RID: 2100
		[global::Cpp2ILInjected.Token(Token = "0x4000A99")]
		NotOnFaulted = 131072,
		// Token: 0x04000835 RID: 2101
		[global::Cpp2ILInjected.Token(Token = "0x4000A9A")]
		NotOnCanceled = 262144,
		// Token: 0x04000836 RID: 2102
		[global::Cpp2ILInjected.Token(Token = "0x4000A9B")]
		OnlyOnRanToCompletion = 393216,
		// Token: 0x04000837 RID: 2103
		[global::Cpp2ILInjected.Token(Token = "0x4000A9C")]
		OnlyOnFaulted = 327680,
		// Token: 0x04000838 RID: 2104
		[global::Cpp2ILInjected.Token(Token = "0x4000A9D")]
		OnlyOnCanceled = 196608,
		// Token: 0x04000839 RID: 2105
		[global::Cpp2ILInjected.Token(Token = "0x4000A9E")]
		ExecuteSynchronously = 524288
	}
}
