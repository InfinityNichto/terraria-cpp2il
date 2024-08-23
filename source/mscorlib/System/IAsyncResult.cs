using System;
using System.Threading;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000092 RID: 146
	[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
	public interface IAsyncResult
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060006AE RID: 1710
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000753")]
			get;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060006AF RID: 1711
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		global::System.Threading.WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000754")]
			get;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060006B0 RID: 1712
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000755")]
			get;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060006B1 RID: 1713
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000756")]
			get;
		}
	}
}
