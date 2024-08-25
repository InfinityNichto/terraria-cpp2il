using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
	public enum X509FindType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004AD")]
		FindByThumbprint,
		[global::Cpp2ILInjected.Token(Token = "0x40004AE")]
		FindBySubjectName,
		[global::Cpp2ILInjected.Token(Token = "0x40004AF")]
		FindBySubjectDistinguishedName,
		[global::Cpp2ILInjected.Token(Token = "0x40004B0")]
		FindByIssuerName,
		[global::Cpp2ILInjected.Token(Token = "0x40004B1")]
		FindByIssuerDistinguishedName,
		[global::Cpp2ILInjected.Token(Token = "0x40004B2")]
		FindBySerialNumber,
		[global::Cpp2ILInjected.Token(Token = "0x40004B3")]
		FindByTimeValid,
		[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
		FindByTimeNotYetValid,
		[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
		FindByTimeExpired,
		[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
		FindByTemplateName,
		[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
		FindByApplicationPolicy,
		[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
		FindByCertificatePolicy,
		[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
		FindByExtension,
		[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
		FindByKeyUsage,
		[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
		FindBySubjectKeyIdentifier
	}
}
