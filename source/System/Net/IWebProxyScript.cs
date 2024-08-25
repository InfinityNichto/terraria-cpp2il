using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000260")]
	public interface IWebProxyScript
	{
		[global::Cpp2ILInjected.Token(Token = "0x600105F")]
		void Close();

		[global::Cpp2ILInjected.Token(Token = "0x6001060")]
		bool Load(Uri scriptLocation, string script, Type helperType);

		[global::Cpp2ILInjected.Token(Token = "0x6001061")]
		string Run(string url, string host);
	}
}
