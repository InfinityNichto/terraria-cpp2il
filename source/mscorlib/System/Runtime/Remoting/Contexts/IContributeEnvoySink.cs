using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002CD RID: 717
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000370")]
	public interface IContributeEnvoySink
	{
		// Token: 0x06001AEA RID: 6890
		[global::Cpp2ILInjected.Token(Token = "0x6001D17")]
		global::System.Runtime.Remoting.Messaging.IMessageSink GetEnvoySink(global::System.MarshalByRefObject obj, global::System.Runtime.Remoting.Messaging.IMessageSink nextSink);
	}
}
