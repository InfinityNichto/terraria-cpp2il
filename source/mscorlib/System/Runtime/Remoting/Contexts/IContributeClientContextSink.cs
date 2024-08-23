using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002CB RID: 715
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036E")]
	public interface IContributeClientContextSink
	{
		// Token: 0x06001AE8 RID: 6888
		[global::Cpp2ILInjected.Token(Token = "0x6001D15")]
		global::System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(global::System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
