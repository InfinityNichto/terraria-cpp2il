using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020001A2 RID: 418
	[global::Cpp2ILInjected.Token(Token = "0x2000260")]
	public interface IWebProxyScript
	{
		// Token: 0x06000EC3 RID: 3779
		[global::Cpp2ILInjected.Token(Token = "0x600105F")]
		void Close();

		// Token: 0x06000EC4 RID: 3780
		[global::Cpp2ILInjected.Token(Token = "0x6001060")]
		bool Load(Uri scriptLocation, string script, Type helperType);

		// Token: 0x06000EC5 RID: 3781
		[global::Cpp2ILInjected.Token(Token = "0x6001061")]
		string Run(string url, string host);
	}
}
