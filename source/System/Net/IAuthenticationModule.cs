using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000110 RID: 272
	[global::Cpp2ILInjected.Token(Token = "0x2000197")]
	public interface IAuthenticationModule
	{
		// Token: 0x06000950 RID: 2384
		[global::Cpp2ILInjected.Token(Token = "0x6000A5F")]
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		// Token: 0x06000951 RID: 2385
		[global::Cpp2ILInjected.Token(Token = "0x6000A60")]
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000952 RID: 2386
		[global::Cpp2ILInjected.Token(Token = "0x17000216")]
		bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A61")]
			get;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000953 RID: 2387
		[global::Cpp2ILInjected.Token(Token = "0x17000217")]
		string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A62")]
			get;
		}
	}
}
