using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AD")]
	public interface IMessageSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E10")]
		IMessage SyncProcessMessage(IMessage msg);

		[global::Cpp2ILInjected.Token(Token = "0x6001E11")]
		IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
	}
}
