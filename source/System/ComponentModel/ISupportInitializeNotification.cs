using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000291 RID: 657
	[global::Cpp2ILInjected.Token(Token = "0x2000388")]
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001554 RID: 5460
		[global::Cpp2ILInjected.Token(Token = "0x17000563")]
		bool IsInitialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600179F")]
			get;
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001555 RID: 5461
		// (remove) Token: 0x06001556 RID: 5462
		[global::Cpp2ILInjected.Token(Token = "0x14000014")]
		event EventHandler Initialized;
	}
}
