﻿using System;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;
using Mono.Security.X509;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000A8 RID: 168
	[global::Cpp2ILInjected.Token(Token = "0x2000105")]
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		// Token: 0x06000511 RID: 1297 RVA: 0x00003CBC File Offset: 0x00001EBC
		[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED228C", Offset = "0x1ED228C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00003CBF File Offset: 0x00001EBF
		[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED22E4", Offset = "0x1ED22E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", ReturnType = typeof(void))]
		public X509Certificate2()
		{
			throw null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00003CC2 File Offset: 0x00001EC2
		[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED22EC", Offset = "0x1ED22EC", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "<.ctor>b__24_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper", Member = "Import", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle",
			typeof(X509KeyStorageFlags)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ImportHandle", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509CertificateImpl" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public X509Certificate2(byte[] rawData)
		{
			throw null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003CC5 File Offset: 0x00001EC5
		[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED24B8", Offset = "0x1ED24B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "LoadCertificateAndKey", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509CertificateImpl" }, ReturnType = typeof(void))]
		internal X509Certificate2(X509Certificate2Impl impl)
		{
			throw null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00003CC8 File Offset: 0x00001EC8
		[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED24C0", Offset = "0x1ED24C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "LoadCertificateAndKey", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public X509Certificate2(string fileName)
		{
			throw null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003CCB File Offset: 0x00001ECB
		[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED24C8", Offset = "0x1ED24C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		public X509Certificate2(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003CCE File Offset: 0x00001ECE
		[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED24D0", Offset = "0x1ED24D0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected X509Certificate2(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00003CD1 File Offset: 0x00001ED1
		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public X509ExtensionCollection Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2510", Offset = "0x1ED2510", Length = "0x398")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public bool HasPrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2AF8", Offset = "0x1ED2AF8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00003CD7 File Offset: 0x00001ED7
		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public unsafe AsymmetricAlgorithm PrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2B24", Offset = "0x1ED2B24", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(UnityTls.unitytls_errorstate*),
				typeof(ref UnityTls.unitytls_x509list*),
				typeof(ref UnityTls.unitytls_key*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00003CDA File Offset: 0x00001EDA
		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public X500DistinguishedName IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2C8C", Offset = "0x1ED2C8C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00003CDD File Offset: 0x00001EDD
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public DateTime NotAfter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2CE0", Offset = "0x1ED2CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00003CE0 File Offset: 0x00001EE0
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public DateTime NotBefore
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2CE8", Offset = "0x1ED2CE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00003CE3 File Offset: 0x00001EE3
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		public PublicKey PublicKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2CF0", Offset = "0x1ED2CF0", Length = "0x150")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Oid),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Oid),
				typeof(AsnEncodedData),
				typeof(AsnEncodedData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00003CE6 File Offset: 0x00001EE6
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2E40", Offset = "0x1ED2E40", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Internal.Cryptography.Helpers", Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00003CE9 File Offset: 0x00001EE9
		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public string SerialNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2E94", Offset = "0x1ED2E94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00003CEC File Offset: 0x00001EEC
		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public Oid SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2EA4", Offset = "0x1ED2EA4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = "FromOidValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(OidGroup)
			}, ReturnType = typeof(Oid))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00003CEF File Offset: 0x00001EEF
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public X500DistinguishedName SubjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2F00", Offset = "0x1ED2F00", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00003CF2 File Offset: 0x00001EF2
		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public string Thumbprint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2F54", Offset = "0x1ED2F54", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Internal.Cryptography.Helpers", Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00003CF5 File Offset: 0x00001EF5
		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED2F70", Offset = "0x1ED2F70", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00003CF8 File Offset: 0x00001EF8
		[global::Cpp2ILInjected.Token(Token = "0x60005CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED2FC4", Offset = "0x1ED2FC4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle",
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImpl), Member = "GetCertContentType", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509ContentType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			throw null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00003CFB File Offset: 0x00001EFB
		[global::Cpp2ILInjected.Token(Token = "0x60005CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED3054", Offset = "0x1ED3054", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			throw null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00003CFE File Offset: 0x00001EFE
		[global::Cpp2ILInjected.Token(Token = "0x60005CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED3088", Offset = "0x1ED3088", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00003D01 File Offset: 0x00001F01
		[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED3094", Offset = "0x1ED3094", Length = "0xE5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Internal.Cryptography.Helpers", Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = "get_FriendlyName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "GetEnumerator", ReturnType = typeof(X509ExtensionEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionEnumerator), Member = "get_Current", ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		public override string ToString(bool verbose)
		{
			throw null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00003D04 File Offset: 0x00001F04
		[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED3EF0", Offset = "0x1ED3EF0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Verify()
		{
			throw null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00003D07 File Offset: 0x00001F07
		[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED2934", Offset = "0x1ED2934", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImpl), Member = "get_SupportsLegacyBasicConstraintsExtension", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			throw null;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00003D0A File Offset: 0x00001F0A
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		internal new X509Certificate2Impl Impl
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED28A8", Offset = "0x1ED28A8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "GetNameInfo", MemberParameters = new object[]
			{
				typeof(X509NameType),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "Verify", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "LoadCertificateAndKey", MemberParameters = new object[]
			{
				typeof(IPAddress),
				typeof(int)
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper", Member = "ThrowIfContextInvalid", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509CertificateImpl" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private byte[] lazyRawData;

		// Token: 0x0400038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Oid lazySignatureAlgorithm;

		// Token: 0x0400038E RID: 910
		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int lazyVersion;

		// Token: 0x0400038F RID: 911
		[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private X500DistinguishedName lazySubjectName;

		// Token: 0x04000390 RID: 912
		[global::Cpp2ILInjected.Token(Token = "0x40004F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private X500DistinguishedName lazyIssuerName;

		// Token: 0x04000391 RID: 913
		[global::Cpp2ILInjected.Token(Token = "0x40004FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private PublicKey lazyPublicKey;

		// Token: 0x04000392 RID: 914
		[global::Cpp2ILInjected.Token(Token = "0x40004FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private AsymmetricAlgorithm lazyPrivateKey;

		// Token: 0x04000393 RID: 915
		[global::Cpp2ILInjected.Token(Token = "0x40004FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private X509ExtensionCollection lazyExtensions;
	}
}