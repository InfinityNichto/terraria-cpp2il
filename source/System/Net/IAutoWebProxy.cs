using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000161 RID: 353
	[global::Cpp2ILInjected.Token(Token = "0x20001F5")]
	internal interface IAutoWebProxy : IWebProxy
	{
		// Token: 0x06000B30 RID: 2864
		[global::Cpp2ILInjected.Token(Token = "0x6000C5C")]
		ProxyChain GetProxies(Uri destination);
	}
}
