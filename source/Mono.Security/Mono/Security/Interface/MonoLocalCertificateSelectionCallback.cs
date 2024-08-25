using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x200004B")]
	public delegate X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
