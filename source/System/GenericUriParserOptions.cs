using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000037 RID: 55
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	public enum GenericUriParserOptions
	{
		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		Default = 0,
		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		GenericAuthority = 1,
		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		AllowEmptyAuthority = 2,
		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		NoUserInfo = 4,
		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		NoPort = 8,
		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		NoQuery = 16,
		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		NoFragment = 32,
		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		DontConvertPathBackslashes = 64,
		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		DontCompressPath = 128,
		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		DontUnescapePathDotsAndSlashes = 256,
		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		Idn = 512,
		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		IriParsing = 1024
	}
}
