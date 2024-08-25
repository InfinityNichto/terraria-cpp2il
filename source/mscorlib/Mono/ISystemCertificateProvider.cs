using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	internal interface ISystemCertificateProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None);

		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, global::System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None);

		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		global::System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(global::System.Security.Cryptography.X509Certificates.X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None);
	}
}
