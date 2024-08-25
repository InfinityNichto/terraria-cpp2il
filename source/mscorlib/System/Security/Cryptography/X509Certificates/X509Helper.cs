using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000324")]
	internal static class X509Helper
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700030E")]
		private static global::Mono.ISystemCertificateProvider CertificateProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1E874", Offset = "0x1B1E874", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509CertificateImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509CertificateImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper), Member = "Import", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle),
				typeof(X509KeyStorageFlags)
			}, ReturnType = typeof(X509CertificateImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D8BC", Offset = "0x1B1D8BC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(global::Mono.ISystemCertificateProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static X509CertificateImpl InitFromCertificate(X509Certificate cert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D394", Offset = "0x1B1D394", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E268", Offset = "0x1B1E268", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsValid(X509CertificateImpl impl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E4F4", Offset = "0x1B1E4F4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetRawCertData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithm", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetKeyAlgorithmParameters", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetPublicKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Impl", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E570", Offset = "0x1B1E570", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.Exception GetInvalidContextException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D24C", Offset = "0x1B1D24C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(global::Mono.ISystemCertificateProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static X509CertificateImpl Import(byte[] rawData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D720", Offset = "0x1B1D720", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(global::Mono.ISystemCertificateProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static X509CertificateImpl Import(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			throw null;
		}
	}
}
