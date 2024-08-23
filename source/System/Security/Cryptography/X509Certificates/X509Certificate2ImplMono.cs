using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;
using Mono;
using Mono.Security.Authenticode;
using Mono.Security.Cryptography;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AC RID: 172
	[global::Cpp2ILInjected.Token(Token = "0x2000109")]
	internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00003D43 File Offset: 0x00001F43
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public override bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED59A0", Offset = "0x1ED59A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00003D46 File Offset: 0x00001F46
		[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED59B0", Offset = "0x1ED59B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		public X509Certificate2ImplMono(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00003D49 File Offset: 0x00001F49
		[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED59E0", Offset = "0x1ED59E0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Clone", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
		private X509Certificate2ImplMono(X509Certificate2ImplMono other)
		{
			throw null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003D4C File Offset: 0x00001F4C
		[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5A74", Offset = "0x1ED5A74", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle",
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "GetCertContentType", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509ContentType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle"
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			throw null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00003D4F File Offset: 0x00001F4F
		[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5C14", Offset = "0x1ED5C14", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate2ImplMono) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override X509CertificateImpl Clone()
		{
			throw null;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00003D52 File Offset: 0x00001F52
		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		private X509Certificate Cert
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED5C78", Offset = "0x1ED5C78", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00003D55 File Offset: 0x00001F55
		[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5C94", Offset = "0x1ED5C94", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override byte[] GetRawCertData()
		{
			throw null;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00003D58 File Offset: 0x00001F58
		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public override bool HasPrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED5CC4", Offset = "0x1ED5CC4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00003D5B File Offset: 0x00001F5B
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003D5E File Offset: 0x00001F5E
		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		public override AsymmetricAlgorithm PrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED5CE8", Offset = "0x1ED5CE8", Length = "0x398")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAManaged), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6080", Offset = "0x1ED6080", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00003D61 File Offset: 0x00001F61
		[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6200", Offset = "0x1ED6200", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override RSA GetRSAPrivateKey()
		{
			throw null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003D64 File Offset: 0x00001F64
		[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED628C", Offset = "0x1ED628C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override DSA GetDSAPrivateKey()
		{
			throw null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00003D67 File Offset: 0x00001F67
		[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5BBC", Offset = "0x1ED5BBC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle",
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(X509Certificate))]
		private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password)
		{
			throw null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003D6A File Offset: 0x00001F6A
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6318", Offset = "0x1ED6318", Length = "0x744")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle"
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateImplCollection), Member = "Add", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509CertificateImpl",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private X509Certificate ImportPkcs12(byte[] rawData, string password)
		{
			throw null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00003D6D File Offset: 0x00001F6D
		[MonoTODO("by default this depends on the incomplete X509Chain")]
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6BA0", Offset = "0x1ED6BA0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "Create", ReturnType = typeof(X509Chain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509ChainImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			throw null;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00003D70 File Offset: 0x00001F70
		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6CDC", Offset = "0x1ED6CDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00003D73 File Offset: 0x00001F73
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		internal X509Certificate MonoCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6CE4", Offset = "0x1ED6CE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003D76 File Offset: 0x00001F76
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6CEC", Offset = "0x1ED6CEC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static X509Certificate2ImplMono()
		{
			throw null;
		}

		// Token: 0x04000396 RID: 918
		[global::Cpp2ILInjected.Token(Token = "0x40004FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private X509CertificateImplCollection intermediateCerts;

		// Token: 0x04000397 RID: 919
		[global::Cpp2ILInjected.Token(Token = "0x4000500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private X509Certificate _cert;

		// Token: 0x04000398 RID: 920
		[global::Cpp2ILInjected.Token(Token = "0x4000501")]
		private static string empty_error;

		// Token: 0x04000399 RID: 921
		[global::Cpp2ILInjected.Token(Token = "0x4000502")]
		private static byte[] signedData;
	}
}
