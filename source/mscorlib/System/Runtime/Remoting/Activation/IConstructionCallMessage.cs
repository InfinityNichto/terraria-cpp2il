using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E5 RID: 741
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000389")]
	public interface IConstructionCallMessage : global::System.Runtime.Remoting.Messaging.IMessage, global::System.Runtime.Remoting.Messaging.IMethodCallMessage, global::System.Runtime.Remoting.Messaging.IMethodMessage
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001B35 RID: 6965
		[global::Cpp2ILInjected.Token(Token = "0x1700037C")]
		global::System.Type ActivationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D62")]
			get;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001B36 RID: 6966
		[global::Cpp2ILInjected.Token(Token = "0x1700037D")]
		string ActivationTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D63")]
			get;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001B37 RID: 6967
		// (set) Token: 0x06001B38 RID: 6968
		[global::Cpp2ILInjected.Token(Token = "0x1700037E")]
		IActivator Activator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D64")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001D65")]
			set;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001B39 RID: 6969
		[global::Cpp2ILInjected.Token(Token = "0x1700037F")]
		object[] CallSiteActivationAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D66")]
			get;
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001B3A RID: 6970
		[global::Cpp2ILInjected.Token(Token = "0x17000380")]
		global::System.Collections.IList ContextProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D67")]
			get;
		}
	}
}
