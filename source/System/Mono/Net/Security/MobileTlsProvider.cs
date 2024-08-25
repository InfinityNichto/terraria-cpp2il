using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000060")]
	internal abstract class MobileTlsProvider : MonoTlsProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

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
