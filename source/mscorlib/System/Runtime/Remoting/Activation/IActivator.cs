using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E4 RID: 740
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000388")]
	public interface IActivator
	{
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001B33 RID: 6963
		[global::Cpp2ILInjected.Token(Token = "0x1700037B")]
		IActivator NextActivator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D60")]
			get;
		}

		// Token: 0x06001B34 RID: 6964
		[global::Cpp2ILInjected.Token(Token = "0x6001D61")]
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
