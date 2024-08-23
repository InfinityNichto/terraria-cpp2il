using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001B7 RID: 439
	[global::Cpp2ILInjected.Token(Token = "0x2000231")]
	public enum TaskStatus
	{
		// Token: 0x040007FA RID: 2042
		[global::Cpp2ILInjected.Token(Token = "0x4000A51")]
		Created,
		// Token: 0x040007FB RID: 2043
		[global::Cpp2ILInjected.Token(Token = "0x4000A52")]
		WaitingForActivation,
		// Token: 0x040007FC RID: 2044
		[global::Cpp2ILInjected.Token(Token = "0x4000A53")]
		WaitingToRun,
		// Token: 0x040007FD RID: 2045
		[global::Cpp2ILInjected.Token(Token = "0x4000A54")]
		Running,
		// Token: 0x040007FE RID: 2046
		[global::Cpp2ILInjected.Token(Token = "0x4000A55")]
		WaitingForChildrenToComplete,
		// Token: 0x040007FF RID: 2047
		[global::Cpp2ILInjected.Token(Token = "0x4000A56")]
		RanToCompletion,
		// Token: 0x04000800 RID: 2048
		[global::Cpp2ILInjected.Token(Token = "0x4000A57")]
		Canceled,
		// Token: 0x04000801 RID: 2049
		[global::Cpp2ILInjected.Token(Token = "0x4000A58")]
		Faulted
	}
}
