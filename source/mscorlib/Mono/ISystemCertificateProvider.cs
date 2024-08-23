using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000008 RID: 8
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	internal interface ISystemCertificateProvider
	{
		// Token: 0x06000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None);

		// Token: 0x06000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None);

		// Token: 0x06000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(global::System.Security.Cryptography.X509Certificates.X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None);
	}
}
