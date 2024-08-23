using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002BE RID: 702
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200035E")]
	public interface ISponsor
	{
		// Token: 0x06001A93 RID: 6803
		[global::Cpp2ILInjected.Token(Token = "0x6001CB8")]
		global::System.TimeSpan Renewal(ILease lease);
	}
}
