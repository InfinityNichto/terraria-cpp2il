using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B0")]
	public interface IMethodReturnMessage : IMethodMessage, IMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x170003C1")]
		global::System.Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C2")]
		object[] OutArgs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003C3")]
		object ReturnValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E1D")]
			get;
		}
	}
}
