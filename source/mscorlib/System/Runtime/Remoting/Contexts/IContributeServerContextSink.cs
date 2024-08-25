using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000372")]
	public interface IContributeServerContextSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D19")]
		global::System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(global::System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
