using System;
using Cpp2ILInjected;

namespace System
{
	// Token: 0x02000046 RID: 70
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	internal enum UriSyntaxFlags
	{
		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		None = 0,
		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		MustHaveAuthority = 1,
		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		OptionalAuthority = 2,
		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		MayHaveUserInfo = 4,
		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		MayHavePort = 8,
		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		MayHavePath = 16,
		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		MayHaveQuery = 32,
		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		MayHaveFragment = 64,
		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x400024F")]
		AllowEmptyHost = 128,
		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x4000250")]
		AllowUncHost = 256,
		// Token: 0x04000128 RID: 296
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		AllowDnsHost = 512,
		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		AllowIPv4Host = 1024,
		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		AllowIPv6Host = 2048,
		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x4000254")]
		AllowAnInternetHost = 3584,
		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x4000255")]
		AllowAnyOtherHost = 4096,
		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x4000256")]
		FileLikeUri = 8192,
		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		MailToLikeUri = 16384,
		// Token: 0x0400012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		V1_UnknownUri = 65536,
		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		SimpleUserSyntax = 131072,
		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		BuiltInSyntax = 262144,
		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		ParserSchemeOnly = 524288,
		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		AllowDOSPath = 1048576,
		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		PathIsRooted = 2097152,
		// Token: 0x04000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		ConvertPathSlashes = 4194304,
		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		CompressPath = 8388608,
		// Token: 0x04000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		AllowIdn = 67108864,
		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		AllowIriParsing = 268435456
	}
}
