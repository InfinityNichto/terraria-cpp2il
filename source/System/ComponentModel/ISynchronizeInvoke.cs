using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x0200024C RID: 588
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface ISynchronizeInvoke
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001362 RID: 4962
		[global::Cpp2ILInjected.Token(Token = "0x170004EF")]
		bool InvokeRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015A1")]
			get;
		}

		// Token: 0x06001363 RID: 4963
		[global::Cpp2ILInjected.Token(Token = "0x60015A2")]
		IAsyncResult BeginInvoke(Delegate method, object[] args);

		// Token: 0x06001364 RID: 4964
		[global::Cpp2ILInjected.Token(Token = "0x60015A3")]
		object EndInvoke(IAsyncResult result);

		// Token: 0x06001365 RID: 4965
		[global::Cpp2ILInjected.Token(Token = "0x60015A4")]
		object Invoke(Delegate method, object[] args);
	}
}
