using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001BB RID: 443
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000239")]
	public enum TaskCreationOptions
	{
		// Token: 0x0400081B RID: 2075
		[global::Cpp2ILInjected.Token(Token = "0x4000A80")]
		None = 0,
		// Token: 0x0400081C RID: 2076
		[global::Cpp2ILInjected.Token(Token = "0x4000A81")]
		PreferFairness = 1,
		// Token: 0x0400081D RID: 2077
		[global::Cpp2ILInjected.Token(Token = "0x4000A82")]
		LongRunning = 2,
		// Token: 0x0400081E RID: 2078
		[global::Cpp2ILInjected.Token(Token = "0x4000A83")]
		AttachedToParent = 4,
		// Token: 0x0400081F RID: 2079
		[global::Cpp2ILInjected.Token(Token = "0x4000A84")]
		DenyChildAttach = 8,
		// Token: 0x04000820 RID: 2080
		[global::Cpp2ILInjected.Token(Token = "0x4000A85")]
		HideScheduler = 16,
		// Token: 0x04000821 RID: 2081
		[global::Cpp2ILInjected.Token(Token = "0x4000A86")]
		RunContinuationsAsynchronously = 64
	}
}
