using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace System.Runtime.Remoting
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200033D")]
	public interface IEnvoyInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000329")]
		global::System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BBC")]
			get;
		}
	}
}
