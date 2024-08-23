using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x02000111 RID: 273
	[global::Cpp2ILInjected.Token(Token = "0x2000198")]
	public interface ICertificatePolicy
	{
		// Token: 0x06000954 RID: 2388
		[global::Cpp2ILInjected.Token(Token = "0x6000A63")]
		bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
	}
}
