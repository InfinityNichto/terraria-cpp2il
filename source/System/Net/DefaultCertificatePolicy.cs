using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000237")]
	internal class DefaultCertificatePolicy : ICertificatePolicy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F402C4", Offset = "0x1F402C4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "get_ServerCertificateValidationCallback", ReturnType = typeof(RemoteCertificateValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool CheckValidationResult(ServicePoint point, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40340", Offset = "0x1F40340", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "get_CertificatePolicy", ReturnType = typeof(ICertificatePolicy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultCertificatePolicy()
		{
			throw null;
		}
	}
}
