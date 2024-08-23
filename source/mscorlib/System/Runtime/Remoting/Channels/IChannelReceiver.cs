using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002DA RID: 730
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200037E")]
	public interface IChannelReceiver : IChannel
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B19 RID: 6937
		[global::Cpp2ILInjected.Token(Token = "0x17000371")]
		object ChannelData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D46")]
			get;
		}

		// Token: 0x06001B1A RID: 6938
		[global::Cpp2ILInjected.Token(Token = "0x6001D47")]
		void StartListening(object data);
	}
}
