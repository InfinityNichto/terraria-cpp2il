using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036E")]
	public interface IContributeClientContextSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D15")]
		global::System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(global::System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
