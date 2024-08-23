using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002DB RID: 731
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200037F")]
	public interface IChannelSender : IChannel
	{
		// Token: 0x06001B1B RID: 6939
		[global::Cpp2ILInjected.Token(Token = "0x6001D48")]
		global::System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
	}
}
