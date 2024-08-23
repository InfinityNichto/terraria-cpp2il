using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace System.Net.Security
{
	// Token: 0x0200022E RID: 558
	// (Invoke) Token: 0x06001279 RID: 4729
	[global::Cpp2ILInjected.Token(Token = "0x200031E")]
	public delegate X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
