using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002D0 RID: 720
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000373")]
	public interface IDynamicMessageSink
	{
		// Token: 0x06001AED RID: 6893
		[global::Cpp2ILInjected.Token(Token = "0x6001D1A")]
		void ProcessMessageFinish(global::System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync);

		// Token: 0x06001AEE RID: 6894
		[global::Cpp2ILInjected.Token(Token = "0x6001D1B")]
		void ProcessMessageStart(global::System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
