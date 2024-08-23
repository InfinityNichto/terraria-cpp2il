using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000308 RID: 776
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AD")]
	public interface IMessageSink
	{
		// Token: 0x06001BDE RID: 7134
		[global::Cpp2ILInjected.Token(Token = "0x6001E10")]
		IMessage SyncProcessMessage(IMessage msg);

		// Token: 0x06001BDF RID: 7135
		[global::Cpp2ILInjected.Token(Token = "0x6001E11")]
		IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
	}
}
