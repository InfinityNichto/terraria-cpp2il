using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000373")]
	public interface IDynamicMessageSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D1A")]
		void ProcessMessageFinish(global::System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync);

		[global::Cpp2ILInjected.Token(Token = "0x6001D1B")]
		void ProcessMessageStart(global::System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
