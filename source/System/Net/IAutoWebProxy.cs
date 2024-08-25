using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F5")]
	internal interface IAutoWebProxy : IWebProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C5C")]
		ProxyChain GetProxies(Uri destination);
	}
}
