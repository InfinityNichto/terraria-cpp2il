using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	internal static class Debug
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002EA0 File Offset: 0x000010A0
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41A78", Offset = "0x1D41A78", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(UnityTls.unitytls_x509verify_result),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(MonoSslAuthenticationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "StartHandshake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002EA3 File Offset: 0x000010A3
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41B10", Offset = "0x1D41B10", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "CheckAndThrow", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_errorstate),
			typeof(string),
			typeof(AlertDescription)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTlsConversions), Member = "VerifyResultToAlertDescription", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509verify_result),
			typeof(AlertDescription)
		}, ReturnType = typeof(AlertDescription))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			throw null;
		}
	}
}
