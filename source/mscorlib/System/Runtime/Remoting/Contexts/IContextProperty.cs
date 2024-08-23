using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x020002CA RID: 714
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200036D")]
	public interface IContextProperty
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001AE5 RID: 6885
		[global::Cpp2ILInjected.Token(Token = "0x17000366")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D12")]
			get;
		}

		// Token: 0x06001AE6 RID: 6886
		[global::Cpp2ILInjected.Token(Token = "0x6001D13")]
		void Freeze(Context newContext);

		// Token: 0x06001AE7 RID: 6887
		[global::Cpp2ILInjected.Token(Token = "0x6001D14")]
		bool IsNewContextOK(Context newCtx);
	}
}
