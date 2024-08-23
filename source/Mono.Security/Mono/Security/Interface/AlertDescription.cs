using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x02000028 RID: 40
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	public enum AlertDescription : byte
	{
		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		CloseNotify,
		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		UnexpectedMessage = 10,
		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		BadRecordMAC = 20,
		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		DecryptionFailed_RESERVED,
		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		RecordOverflow,
		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		DecompressionFailure = 30,
		// Token: 0x040000D4 RID: 212
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		HandshakeFailure = 40,
		// Token: 0x040000D5 RID: 213
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		NoCertificate_RESERVED,
		// Token: 0x040000D6 RID: 214
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		BadCertificate,
		// Token: 0x040000D7 RID: 215
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		UnsupportedCertificate,
		// Token: 0x040000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		CertificateRevoked,
		// Token: 0x040000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		CertificateExpired,
		// Token: 0x040000DA RID: 218
		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		CertificateUnknown,
		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		IlegalParameter,
		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		UnknownCA,
		// Token: 0x040000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		AccessDenied,
		// Token: 0x040000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		DecodeError,
		// Token: 0x040000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		DecryptError,
		// Token: 0x040000E0 RID: 224
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		ExportRestriction = 60,
		// Token: 0x040000E1 RID: 225
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		ProtocolVersion = 70,
		// Token: 0x040000E2 RID: 226
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		InsuficientSecurity,
		// Token: 0x040000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		InternalError = 80,
		// Token: 0x040000E4 RID: 228
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		UserCancelled = 90,
		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x4000112")]
		NoRenegotiation = 100,
		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		UnsupportedExtension = 110
	}
}
