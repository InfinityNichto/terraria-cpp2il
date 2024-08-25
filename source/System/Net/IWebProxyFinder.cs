using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200019C")]
	internal interface IWebProxyFinder : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A6D")]
		bool GetProxies(Uri destination, out IList<string> proxyList);

		[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
		void Abort();

		[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
		void Reset();

		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A70")]
			get;
		}
	}
}
