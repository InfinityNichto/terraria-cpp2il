using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Activation
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000389")]
	public interface IConstructionCallMessage : global::System.Runtime.Remoting.Messaging.IMessage, global::System.Runtime.Remoting.Messaging.IMethodCallMessage, global::System.Runtime.Remoting.Messaging.IMethodMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700037C")]
		global::System.Type ActivationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D62")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037D")]
		string ActivationTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D63")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037E")]
		IActivator Activator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D64")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001D65")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037F")]
		object[] CallSiteActivationAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D66")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000380")]
		global::System.Collections.IList ContextProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D67")]
			get;
		}
	}
}
