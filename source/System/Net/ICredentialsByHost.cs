using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000113 RID: 275
	[global::Cpp2ILInjected.Token(Token = "0x200019A")]
	public interface ICredentialsByHost
	{
		// Token: 0x06000956 RID: 2390
		[global::Cpp2ILInjected.Token(Token = "0x6000A65")]
		NetworkCredential GetCredential(string host, int port, string authenticationType);
	}
}
