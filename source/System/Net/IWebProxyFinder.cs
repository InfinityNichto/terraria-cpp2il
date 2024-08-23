using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000115 RID: 277
	[global::Cpp2ILInjected.Token(Token = "0x200019C")]
	internal interface IWebProxyFinder : IDisposable
	{
		// Token: 0x0600095E RID: 2398
		[global::Cpp2ILInjected.Token(Token = "0x6000A6D")]
		bool GetProxies(Uri destination, out IList<string> proxyList);

		// Token: 0x0600095F RID: 2399
		[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
		void Abort();

		// Token: 0x06000960 RID: 2400
		[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
		void Reset();

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000961 RID: 2401
		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A70")]
			get;
		}
	}
}
