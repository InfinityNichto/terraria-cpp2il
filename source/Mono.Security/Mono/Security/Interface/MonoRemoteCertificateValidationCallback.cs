using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x0200002F RID: 47
	// (Invoke) Token: 0x060001A1 RID: 417
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
}
