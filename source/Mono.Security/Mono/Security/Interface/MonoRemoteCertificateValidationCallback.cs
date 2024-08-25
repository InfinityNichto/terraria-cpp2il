using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
}
