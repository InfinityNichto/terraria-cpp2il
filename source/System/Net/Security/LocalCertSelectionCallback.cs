using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace System.Net.Security
{
	// Token: 0x02000231 RID: 561
	// (Invoke) Token: 0x0600127D RID: 4733
	[global::Cpp2ILInjected.Token(Token = "0x2000321")]
	internal delegate X509Certificate LocalCertSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
