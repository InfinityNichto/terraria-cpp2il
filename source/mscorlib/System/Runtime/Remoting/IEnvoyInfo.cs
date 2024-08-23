using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting
{
	// Token: 0x0200029F RID: 671
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200033D")]
	public interface IEnvoyInfo
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001999 RID: 6553
		[global::Cpp2ILInjected.Token(Token = "0x17000329")]
		global::System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BBC")]
			get;
		}
	}
}
