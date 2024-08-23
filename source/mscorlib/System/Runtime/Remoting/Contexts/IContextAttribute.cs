using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002C9 RID: 713
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036C")]
	public interface IContextAttribute
	{
		// Token: 0x06001AE3 RID: 6883
		[global::Cpp2ILInjected.Token(Token = "0x6001D10")]
		void GetPropertiesForNewContext(global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg);

		// Token: 0x06001AE4 RID: 6884
		[global::Cpp2ILInjected.Token(Token = "0x6001D11")]
		bool IsContextOK(Context ctx, global::System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
	}
}
