using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020001A0 RID: 416
	[global::Cpp2ILInjected.Token(Token = "0x200025E")]
	public interface ICredentialPolicy
	{
		// Token: 0x06000EBC RID: 3772
		[global::Cpp2ILInjected.Token(Token = "0x6001058")]
		bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule);
	}
}
