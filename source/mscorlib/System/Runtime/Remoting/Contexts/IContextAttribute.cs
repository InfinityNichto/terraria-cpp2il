using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036C")]
	public interface IContextAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D10")]
		void GetPropertiesForNewContext(global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg);

		[global::Cpp2ILInjected.Token(Token = "0x6001D11")]
		bool IsContextOK(Context ctx, global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
	}
}
