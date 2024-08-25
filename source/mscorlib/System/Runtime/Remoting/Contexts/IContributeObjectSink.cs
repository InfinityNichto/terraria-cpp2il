using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000371")]
	public interface IContributeObjectSink
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D18")]
		global::System.Runtime.Remoting.Messaging.IMessageSink GetObjectSink(global::System.MarshalByRefObject obj, global::System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
