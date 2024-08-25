using System;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	public class X509Chain : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		internal X509ChainImpl Impl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000629")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7D8C", Offset = "0x1ED7D8C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new object[]
			{
				typeof(ChainValidationHelper),
				typeof(string),
				typeof(bool),
				typeof(X509CertificateCollection),
				typeof(bool),
				typeof(ref X509Chain),
				typeof(ref SslPolicyErrors),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7DAC", Offset = "0x1ED7DAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "CreateChainImpl", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(X509ChainImpl))]
		public X509Chain()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7DD4", Offset = "0x1ED7DD4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "CreateChainImpl", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(X509ChainImpl))]
		public X509Chain(bool useMachineContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7E08", Offset = "0x1ED7E08", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(ChainValidationHelper),
			typeof(string),
			typeof(bool),
			typeof(X509CertificateCollection),
			typeof(bool),
			typeof(ref X509Chain),
			typeof(ref SslPolicyErrors),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		internal unsafe X509Chain(X509ChainImpl impl)
		{
			throw null;
		}

		[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7E3C", Offset = "0x1ED7E3C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509Chain(IntPtr chainContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public unsafe X509ChainElementCollection ChainElements
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7E7C", Offset = "0x1ED7E7C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list_ref),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public X509ChainPolicy ChainPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600062F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7EA4", Offset = "0x1ED7EA4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		[global::Cpp2ILInjected.Token(Token = "0x6000630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6CA4", Offset = "0x1ED6CA4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Build(X509Certificate2 certificate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7ECC", Offset = "0x1ED7ECC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6C40", Offset = "0x1ED6C40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Verify", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "CreateChainImpl", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(X509ChainImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static X509Chain Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7EF4", Offset = "0x1ED7EF4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(ChainValidationHelper),
			typeof(string),
			typeof(bool),
			typeof(X509CertificateCollection),
			typeof(bool),
			typeof(ref X509Chain),
			typeof(ref SslPolicyErrors),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(X509CertificateCollection),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(ValidationResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7F60", Offset = "0x1ED7F60", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImpl), Member = "Dispose", ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7FEC", Offset = "0x1ED7FEC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000507")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509ChainImpl impl;
	}
}
