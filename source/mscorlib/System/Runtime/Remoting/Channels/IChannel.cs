using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002D8 RID: 728
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200037C")]
	public interface IChannel
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B17 RID: 6935
		[global::Cpp2ILInjected.Token(Token = "0x1700036F")]
		string ChannelName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D44")]
			get;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B18 RID: 6936
		[global::Cpp2ILInjected.Token(Token = "0x17000370")]
		int ChannelPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D45")]
			get;
		}
	}
}
