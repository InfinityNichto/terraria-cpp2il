using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	internal static class UnityTlsConversions
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002EEE File Offset: 0x000010EE
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44810", Offset = "0x1D44810", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002EF1 File Offset: 0x000010F1
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D44848", Offset = "0x1D44848", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002EF4 File Offset: 0x000010F4
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45408", Offset = "0x1D45408", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002EF7 File Offset: 0x000010F7
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41BE0", Offset = "0x1D41BE0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(UnityTls.unitytls_x509verify_result),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002EFA File Offset: 0x000010FA
		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4675C", Offset = "0x1D4675C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002EFD File Offset: 0x000010FD
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4678C", Offset = "0x1D4678C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
		{
			throw null;
		}
	}
}
