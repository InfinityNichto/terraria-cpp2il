using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	// Token: 0x0200001E RID: 30
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public enum ZipEntryTimestamp
	{
		// Token: 0x0400009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		None = 0,
		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		DOS = 1,
		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		Windows = 2,
		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		Unix = 4,
		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		InfoZip1 = 8
	}
}
