using System;
using Cpp2ILInjected;

namespace System
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	internal enum UriSyntaxFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		MustHaveAuthority = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		OptionalAuthority = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		MayHaveUserInfo = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		MayHavePort = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		MayHavePath = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		MayHaveQuery = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		MayHaveFragment = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400024F")]
		AllowEmptyHost = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000250")]
		AllowUncHost = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		AllowDnsHost = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		AllowIPv4Host = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		AllowIPv6Host = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x4000254")]
		AllowAnInternetHost = 3584,
		[global::Cpp2ILInjected.Token(Token = "0x4000255")]
		AllowAnyOtherHost = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x4000256")]
		FileLikeUri = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		MailToLikeUri = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		V1_UnknownUri = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		SimpleUserSyntax = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		BuiltInSyntax = 262144,
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		ParserSchemeOnly = 524288,
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		AllowDOSPath = 1048576,
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		PathIsRooted = 2097152,
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		ConvertPathSlashes = 4194304,
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		CompressPath = 8388608,
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		CanonicalizeAsFilePath = 16777216,
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		UnEscapeDotsAndSlashes = 33554432,
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		AllowIdn = 67108864,
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		AllowIriParsing = 268435456
	}
}
