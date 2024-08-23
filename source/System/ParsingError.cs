using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x0200003F RID: 63
	[global::Cpp2ILInjected.Token(Token = "0x200008E")]
	internal enum ParsingError
	{
		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		None,
		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		BadFormat,
		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		BadScheme,
		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		BadAuthority,
		// Token: 0x040000EA RID: 234
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		EmptyUriString,
		// Token: 0x040000EB RID: 235
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x040000EC RID: 236
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		SchemeLimit,
		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		SizeLimit,
		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		MustRootedPath,
		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		BadHostName,
		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		NonEmptyHost,
		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		BadPort,
		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		BadAuthorityTerminator,
		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		CannotCreateRelative
	}
}
