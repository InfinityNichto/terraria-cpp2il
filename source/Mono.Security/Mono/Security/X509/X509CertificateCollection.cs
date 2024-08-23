using System;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;

namespace Mono.Security.X509
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000031B0 File Offset: 0x000013B0
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A906A4", Offset = "0x1A906A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509CertificateCollection()
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000031B3 File Offset: 0x000013B3
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A906AC", Offset = "0x1A906AC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509CertificateCollection(X509Certificate[] value)
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000031B6 File Offset: 0x000013B6
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90784", Offset = "0x1A90784", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509CertificateCollection(X509CertificateCollection value)
		{
			throw null;
		}

		// Token: 0x1700003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public X509Certificate this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000106")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90888", Offset = "0x1A90888", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string)
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000107")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90918", Offset = "0x1A90918", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000031BF File Offset: 0x000013BF
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9092C", Offset = "0x1A9092C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "LoadCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int Add(X509Certificate value)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000031C2 File Offset: 0x000013C2
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A906D8", Offset = "0x1A906D8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddRange(X509Certificate[] value)
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000031C5 File Offset: 0x000013C5
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A907B0", Offset = "0x1A907B0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "LoadCertificates", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_UntrustedCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddRange(X509CertificateCollection value)
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000031C8 File Offset: 0x000013C8
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90994", Offset = "0x1A90994", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		public bool Contains(X509Certificate value)
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000031CB File Offset: 0x000013CB
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90B04", Offset = "0x1A90B04", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(X509Certificate[] array, int index)
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000031CE File Offset: 0x000013CE
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90B18", Offset = "0x1A90B18", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindByIssuerName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(PKCS7.SignedData),
			typeof(byte[]),
			typeof(HashAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new object[]
		{
			typeof(PKCS7.SignerInfo),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000031D1 File Offset: 0x000013D1
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90C24", Offset = "0x1A90C24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000031D4 File Offset: 0x000013D4
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90C38", Offset = "0x1A90C38", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000031D7 File Offset: 0x000013D7
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A909AC", Offset = "0x1A909AC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "Contains", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsTrusted", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Certificate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Compare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int IndexOf(X509Certificate value)
		{
			throw null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000031DA File Offset: 0x000013DA
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90CAC", Offset = "0x1A90CAC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Insert(int index, X509Certificate value)
		{
			throw null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000031DD File Offset: 0x000013DD
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90CC0", Offset = "0x1A90CC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Remove(X509Certificate value)
		{
			throw null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000031E0 File Offset: 0x000013E0
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90C48", Offset = "0x1A90C48", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool Compare(byte[] array1, byte[] array2)
		{
			throw null;
		}

		// Token: 0x0200005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		public class X509CertificateEnumerator : IEnumerator
		{
			// Token: 0x060002B6 RID: 694 RVA: 0x00003735 File Offset: 0x00001935
			[global::Cpp2ILInjected.Token(Token = "0x6000114")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90B70", Offset = "0x1A90B70", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
				throw null;
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060002B7 RID: 695 RVA: 0x00003738 File Offset: 0x00001938
			[global::Cpp2ILInjected.Token(Token = "0x17000054")]
			public X509Certificate Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000115")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A90CD4", Offset = "0x1A90CD4", Length = "0xE8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
				{
					typeof(byte[]),
					typeof(string)
				}, ReturnType = typeof(X509Certificate))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(DSAParameters))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindByIssuerName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new object[]
				{
					typeof(PKCS7.SignedData),
					typeof(byte[]),
					typeof(HashAlgorithm)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new object[]
				{
					typeof(PKCS7.SignerInfo),
					typeof(byte[])
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000373B File Offset: 0x0000193B
			[global::Cpp2ILInjected.Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000116")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A90DBC", Offset = "0x1A90DBC", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000373E File Offset: 0x0000193E
			[global::Cpp2ILInjected.Token(Token = "0x6000117")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90E58", Offset = "0x1A90E58", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private bool System.Collections.IEnumerator.MoveNext()
			{
				throw null;
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00003741 File Offset: 0x00001941
			[global::Cpp2ILInjected.Token(Token = "0x6000118")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90EF0", Offset = "0x1A90EF0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00003744 File Offset: 0x00001944
			[global::Cpp2ILInjected.Token(Token = "0x6000119")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A90F8C", Offset = "0x1A90F8C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string)
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(DSAParameters))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindByIssuerName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new object[]
			{
				typeof(PKCS7.SignedData),
				typeof(byte[]),
				typeof(HashAlgorithm)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new object[]
			{
				typeof(PKCS7.SignerInfo),
				typeof(byte[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00003747 File Offset: 0x00001947
			[global::Cpp2ILInjected.Token(Token = "0x600011A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A91024", Offset = "0x1A91024", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x040002B8 RID: 696
			[global::Cpp2ILInjected.Token(Token = "0x400008D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IEnumerator enumerator;
		}
	}
}
