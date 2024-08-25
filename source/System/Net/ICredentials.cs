using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000199")]
	public interface ICredentials
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A64")]
		NetworkCredential GetCredential(Uri uri, string authType);
	}
}
