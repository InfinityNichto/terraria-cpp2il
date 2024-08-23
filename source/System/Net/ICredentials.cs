using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000112 RID: 274
	[global::Cpp2ILInjected.Token(Token = "0x2000199")]
	public interface ICredentials
	{
		// Token: 0x06000955 RID: 2389
		[global::Cpp2ILInjected.Token(Token = "0x6000A64")]
		NetworkCredential GetCredential(Uri uri, string authType);
	}
}
