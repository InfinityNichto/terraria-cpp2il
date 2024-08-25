using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200021E")]
	public interface IWebProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D98")]
		Uri GetProxy(Uri destination);

		[global::Cpp2ILInjected.Token(Token = "0x6000D99")]
		bool IsBypassed(Uri host);

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
