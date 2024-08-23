using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001E RID: 30
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public interface IJsonLineInfo
	{
		// Token: 0x06000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		bool HasLineInfo();

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			get;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000046 RID: 70
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			get;
		}
	}
}
