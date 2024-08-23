using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000286 RID: 646
	[global::Cpp2ILInjected.Token(Token = "0x2000323")]
	internal abstract class X509CertificateImpl : global::System.IDisposable
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001915 RID: 6421
		[global::Cpp2ILInjected.Token(Token = "0x17000302")]
		public abstract bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B2F")]
			get;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00018BB7 File Offset: 0x00016DB7
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

		// Token: 0x06001917 RID: 6423
		[global::Cpp2ILInjected.Token(Token = "0x6001B31")]
		public abstract X509CertificateImpl Clone();

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001918 RID: 6424
		[global::Cpp2ILInjected.Token(Token = "0x17000303")]
		public abstract string Issuer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B32")]
			get;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001919 RID: 6425
		[global::Cpp2ILInjected.Token(Token = "0x17000304")]
		public abstract string Subject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B33")]
			get;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600191A RID: 6426
		[global::Cpp2ILInjected.Token(Token = "0x17000305")]
		public abstract byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B34")]
			get;
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600191B RID: 6427
		[global::Cpp2ILInjected.Token(Token = "0x17000306")]
		public abstract global::System.DateTime NotAfter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B35")]
			get;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600191C RID: 6428
		[global::Cpp2ILInjected.Token(Token = "0x17000307")]
		public abstract global::System.DateTime NotBefore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B36")]
			get;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600191D RID: 6429
		[global::Cpp2ILInjected.Token(Token = "0x17000308")]
		public abstract byte[] Thumbprint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B37")]
			get;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00018BBA File Offset: 0x00016DBA
		[global::Cpp2ILInjected.Token(Token = "0x6001B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E5F0", Offset = "0x1B1E5F0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public sealed override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600191F RID: 6431
		[global::Cpp2ILInjected.Token(Token = "0x17000309")]
		public abstract string KeyAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B39")]
			get;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001920 RID: 6432
		[global::Cpp2ILInjected.Token(Token = "0x1700030A")]
		public abstract byte[] KeyAlgorithmParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3A")]
			get;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001921 RID: 6433
		[global::Cpp2ILInjected.Token(Token = "0x1700030B")]
		public abstract byte[] PublicKeyValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3B")]
			get;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001922 RID: 6434
		[global::Cpp2ILInjected.Token(Token = "0x1700030C")]
		public abstract byte[] SerialNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3C")]
			get;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001923 RID: 6435
		[global::Cpp2ILInjected.Token(Token = "0x1700030D")]
		public abstract bool HasPrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B3D")]
			get;
		}

		// Token: 0x06001924 RID: 6436
		[global::Cpp2ILInjected.Token(Token = "0x6001B3E")]
		public abstract RSA GetRSAPrivateKey();

		// Token: 0x06001925 RID: 6437
		[global::Cpp2ILInjected.Token(Token = "0x6001B3F")]
		public abstract DSA GetDSAPrivateKey();

		// Token: 0x06001926 RID: 6438
		[global::Cpp2ILInjected.Token(Token = "0x6001B40")]
		public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey);

		// Token: 0x06001927 RID: 6439 RVA: 0x00018BBD File Offset: 0x00016DBD
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

		// Token: 0x06001928 RID: 6440 RVA: 0x00018BC0 File Offset: 0x00016DC0
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

		// Token: 0x06001929 RID: 6441 RVA: 0x00018BC3 File Offset: 0x00016DC3
		[global::Cpp2ILInjected.Token(Token = "0x6001B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E7C4", Offset = "0x1B1E7C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00018BC6 File Offset: 0x00016DC6
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

		// Token: 0x0600192B RID: 6443 RVA: 0x00018BC9 File Offset: 0x00016DC9
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
