using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x0200017B RID: 379
	[global::Cpp2ILInjected.Token(Token = "0x200021E")]
	public interface IWebProxy
	{
		// Token: 0x06000C3A RID: 3130
		[global::Cpp2ILInjected.Token(Token = "0x6000D98")]
		Uri GetProxy(Uri destination);

		// Token: 0x06000C3B RID: 3131
		[global::Cpp2ILInjected.Token(Token = "0x6000D99")]
		bool IsBypassed(Uri host);

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C3C RID: 3132
		// (set) Token: 0x06000C3D RID: 3133
		[global::Cpp2ILInjected.Token(Token = "0x170002DA")]
		ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D9A")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000D9B")]
			set;
		}
	}
}
