using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x02000030 RID: 48
	// (Invoke) Token: 0x060001A3 RID: 419
	[global::Cpp2ILInjected.Token(Token = "0x200004B")]
	public delegate X509Certificate MonoLocalCertificateSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
