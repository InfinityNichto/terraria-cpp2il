using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x020002CA RID: 714
	[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
	public interface IChangeTracking
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600175C RID: 5980
		[global::Cpp2ILInjected.Token(Token = "0x170005DD")]
		bool IsChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019BE")]
			get;
		}

		// Token: 0x0600175D RID: 5981
		[global::Cpp2ILInjected.Token(Token = "0x60019BF")]
		void AcceptChanges();
	}
}
