using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000323")]
	internal abstract class X509CertificateImpl : global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		public abstract bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B2F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E534", Offset = "0x1B1E534", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "Clone", ReturnType = typeof(X509CertificateImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_Cert", ReturnType = "Mono.Security.X509.X509Certificate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "GetRawCertData", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "EnsureCertData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "GetInvalidContextException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void ThrowIfContextInvalid()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B31")]
		public abstract X509CertificateImpl Clone();

		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public abstract string Issuer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B32")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public abstract string Subject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B33")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000305")]
		public abstract byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B34")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000306")]
		public abstract global::System.DateTime NotAfter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B35")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000307")]
		public abstract global::System.DateTime NotBefore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B36")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000308")]
		public abstract byte[] Thumbprint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B37")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E5F0", Offset = "0x1B1E5F0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000309")]
		public abstract string KeyAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B39")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030A")]
		public abstract byte[] KeyAlgorithmParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030B")]
		public abstract byte[] PublicKeyValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030C")]
		public abstract byte[] SerialNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030D")]
		public abstract bool HasPrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B3E")]
		public abstract RSA GetRSAPrivateKey();

		[global::Cpp2ILInjected.Token(Token = "0x6001B3F")]
		public abstract DSA GetDSAPrivateKey();

		[global::Cpp2ILInjected.Token(Token = "0x6001B40")]
		public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey);

		[global::Cpp2ILInjected.Token(Token = "0x6001B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E668", Offset = "0x1B1E668", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D0CC", Offset = "0x1B1D0CC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImplCollection", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E7C4", Offset = "0x1B1E7C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E7C8", Offset = "0x1B1E7C8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E86C", Offset = "0x1B1E86C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle),
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(string)
		}, ReturnType = "Mono.Security.X509.X509Certificate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected X509CertificateImpl()
		{
			throw null;
		}
	}
}
