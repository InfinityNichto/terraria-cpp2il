using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000101")]
	public enum X509VerificationFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
		NoFlag = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
		IgnoreNotTimeValid = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
		IgnoreCtlNotTimeValid = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
		IgnoreNotTimeNested = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
		IgnoreInvalidBasicConstraints = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
		AllowUnknownCertificateAuthority = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
		IgnoreWrongUsage = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
		IgnoreInvalidName = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
		IgnoreInvalidPolicy = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
		IgnoreEndRevocationUnknown = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
		IgnoreCtlSignerRevocationUnknown = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		IgnoreRootRevocationUnknown = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		AllFlags = 4095
	}
}
