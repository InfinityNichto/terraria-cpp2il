using System;
using Cpp2ILInjected;

namespace Internal.Cryptography.Pal
{
	[global::Cpp2ILInjected.Token(Token = "0x2000071")]
	internal enum GeneralNameType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		OtherName,
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		Rfc822Name,
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		Email = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		DnsName,
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		X400Address,
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		DirectoryName,
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		EdiPartyName,
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		UniformResourceIdentifier,
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		IPAddress,
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		RegisteredId
	}
}
