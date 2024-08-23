using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x2000060")]
	internal abstract class MobileTlsProvider : MonoTlsProvider
	{
		// Token: 0x060000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

		// Token: 0x060000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

		// Token: 0x060000DA RID: 218 RVA: 0x0000308F File Offset: 0x0000128F
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47214", Offset = "0x1D47214", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProvider), Member = ".ctor", ReturnType = typeof(void))]
		protected MobileTlsProvider()
		{
			throw null;
		}
	}
}
