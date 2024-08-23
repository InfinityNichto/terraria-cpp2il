using System;
using Cpp2ILInjected;

namespace System.Threading
{
	// Token: 0x02000172 RID: 370
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20001C4")]
	public enum ThreadState
	{
		// Token: 0x0400070A RID: 1802
		[global::Cpp2ILInjected.Token(Token = "0x400090A")]
		Running = 0,
		// Token: 0x0400070B RID: 1803
		[global::Cpp2ILInjected.Token(Token = "0x400090B")]
		StopRequested = 1,
		// Token: 0x0400070C RID: 1804
		[global::Cpp2ILInjected.Token(Token = "0x400090C")]
		SuspendRequested = 2,
		// Token: 0x0400070D RID: 1805
		[global::Cpp2ILInjected.Token(Token = "0x400090D")]
		Background = 4,
		// Token: 0x0400070E RID: 1806
		[global::Cpp2ILInjected.Token(Token = "0x400090E")]
		Unstarted = 8,
		// Token: 0x0400070F RID: 1807
		[global::Cpp2ILInjected.Token(Token = "0x400090F")]
		Stopped = 16,
		// Token: 0x04000710 RID: 1808
		[global::Cpp2ILInjected.Token(Token = "0x4000910")]
		WaitSleepJoin = 32,
		// Token: 0x04000711 RID: 1809
		[global::Cpp2ILInjected.Token(Token = "0x4000911")]
		Suspended = 64,
		// Token: 0x04000712 RID: 1810
		[global::Cpp2ILInjected.Token(Token = "0x4000912")]
		AbortRequested = 128,
		// Token: 0x04000713 RID: 1811
		[global::Cpp2ILInjected.Token(Token = "0x4000913")]
		Aborted = 256
	}
}
