using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200019A")]
	public interface ICredentialsByHost
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A65")]
		NetworkCredential GetCredential(string host, int port, string authenticationType);
	}
}
