using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000197")]
	public interface IAuthenticationModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A5F")]
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		[global::Cpp2ILInjected.Token(Token = "0x6000A60")]
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		[global::Cpp2ILInjected.Token(Token = "0x17000216")]
		bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A61")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000217")]
		string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A62")]
			get;
		}
	}
}
