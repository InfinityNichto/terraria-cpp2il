using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200025E")]
	public interface ICredentialPolicy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001058")]
		bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule);
	}
}
