using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002BD RID: 701
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200035D")]
	public interface ILease
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001A8F RID: 6799
		[global::Cpp2ILInjected.Token(Token = "0x17000352")]
		global::System.TimeSpan CurrentLeaseTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB4")]
			get;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001A90 RID: 6800
		[global::Cpp2ILInjected.Token(Token = "0x17000353")]
		LeaseState CurrentState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB5")]
			get;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001A91 RID: 6801
		[global::Cpp2ILInjected.Token(Token = "0x17000354")]
		global::System.TimeSpan RenewOnCallTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CB6")]
			get;
		}

		// Token: 0x06001A92 RID: 6802
		[global::Cpp2ILInjected.Token(Token = "0x6001CB7")]
		global::System.TimeSpan Renew(global::System.TimeSpan renewalTime);
	}
}
