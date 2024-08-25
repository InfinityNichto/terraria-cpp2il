using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Activation
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000388")]
	public interface IActivator
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700037B")]
		IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D60")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D61")]
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
