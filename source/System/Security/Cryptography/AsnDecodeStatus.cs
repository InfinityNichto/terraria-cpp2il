using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	internal enum AsnDecodeStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		NotDecoded = -1,
		[global::Cpp2ILInjected.Token(Token = "0x400046D")]
		Ok,
		[global::Cpp2ILInjected.Token(Token = "0x400046E")]
		BadAsn,
		[global::Cpp2ILInjected.Token(Token = "0x400046F")]
		BadTag,
		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		BadLength,
		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		InformationNotAvailable
	}
}
