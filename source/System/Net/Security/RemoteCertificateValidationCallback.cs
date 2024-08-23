using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace System.Net.Security
{
	// Token: 0x0200022F RID: 559
	// (Invoke) Token: 0x0600127B RID: 4731
	[global::Cpp2ILInjected.Token(Token = "0x200031F")]
	public delegate bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
}
