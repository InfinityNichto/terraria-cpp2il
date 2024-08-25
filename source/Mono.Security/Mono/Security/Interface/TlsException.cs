using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Unity;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x200004F")]
	public sealed class TlsException : Exception
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BA9C", Offset = "0x1A9BA9C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TlsException(Alert alert, string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9BB10", Offset = "0x1A9BB10", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.Debug", Member = "CheckAndThrow", MemberParameters = new object[]
		{
			"Mono.Unity.UnityTls.unitytls_errorstate",
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.Debug", Member = "CheckAndThrow", MemberParameters = new object[]
		{
			"Mono.Unity.UnityTls.unitytls_errorstate",
			"Mono.Unity.UnityTls.unitytls_x509verify_result",
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ProcessHandshake", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "CertificateCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_tlsctx*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509name*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509list_ref*),
			typeof(UnityTls.unitytls_key_ref*),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = ".ctor", MemberParameters = new object[] { typeof(AlertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Alert),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe TlsException(AlertDescription description, string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Alert alert;
	}
}
