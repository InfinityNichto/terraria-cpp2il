using System;
using Cpp2ILInjected;

namespace System.Configuration.Internal
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public interface IConfigErrorInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		string Filename
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			get;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			get;
		}
	}
}
