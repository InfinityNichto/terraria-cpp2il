using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	public enum AlertDescription : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		CloseNotify,
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		UnexpectedMessage = 10,
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		BadRecordMAC = 20,
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		DecryptionFailed_RESERVED,
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		RecordOverflow,
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		DecompressionFailure = 30,
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		HandshakeFailure = 40,
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		NoCertificate_RESERVED,
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		BadCertificate,
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		UnsupportedCertificate,
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		CertificateRevoked,
		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		CertificateExpired,
		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		CertificateUnknown,
		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		IlegalParameter,
		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		UnknownCA,
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		AccessDenied,
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		DecodeError,
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		DecryptError,
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		ExportRestriction = 60,
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		ProtocolVersion = 70,
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		InsuficientSecurity,
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		InternalError = 80,
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		UserCancelled = 90,
		[global::Cpp2ILInjected.Token(Token = "0x4000112")]
		NoRenegotiation = 100,
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		UnsupportedExtension = 110
	}
}
