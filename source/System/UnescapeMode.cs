using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000040 RID: 64
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200008F")]
	internal enum UnescapeMode
	{
		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		CopyOnly = 0,
		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		Escape = 1,
		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		Unescape = 2,
		// Token: 0x040000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		EscapeUnescape = 3,
		// Token: 0x040000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		V1ToStringFlag = 4,
		// Token: 0x040000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		UnescapeAll = 8,
		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		UnescapeAllOrThrow = 24
	}
}
