using System;
using System.Collections;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;
using Mono.Security.X509;

namespace Mono.Security
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public sealed class PKCS7
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002FAF File Offset: 0x000011AF
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A3B8", Offset = "0x1A7A3B8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Builder), Member = "Build", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "SubjectPublicKeyInfo", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ASN1 AlgorithmIdentifier(string oid)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002FB2 File Offset: 0x000011B2
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7A45C", Offset = "0x1A7A45C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "SubjectPublicKeyInfo", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ASN1 AlgorithmIdentifier(string oid, ASN1 parameters)
		{
			throw null;
		}

		// Token: 0x02000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x2000007")]
		public class ContentInfo
		{
			// Token: 0x06000283 RID: 643 RVA: 0x0000369C File Offset: 0x0000189C
			[global::Cpp2ILInjected.Token(Token = "0x6000026")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A4EC", Offset = "0x1A7A4EC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.EncryptedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new object[]
			{
				typeof(ASN1),
				typeof(string)
			}, ReturnType = typeof(PKCS7.ContentInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ContentInfo()
			{
				throw null;
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0000369F File Offset: 0x0000189F
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A55C", Offset = "0x1A7A55C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
			public ContentInfo(string oid)
			{
				throw null;
			}

			// Token: 0x06000285 RID: 645 RVA: 0x000036A2 File Offset: 0x000018A2
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A580", Offset = "0x1A7A580", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(IDictionary)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(IDictionary)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetCertificate", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ContentInfo(byte[] data)
			{
				throw null;
			}

			// Token: 0x06000286 RID: 646 RVA: 0x000036A5 File Offset: 0x000018A5
			[global::Cpp2ILInjected.Token(Token = "0x6000029")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A5E8", Offset = "0x1A7A5E8", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public ContentInfo(ASN1 asn1)
			{
				throw null;
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000287 RID: 647 RVA: 0x000036A8 File Offset: 0x000018A8
			[global::Cpp2ILInjected.Token(Token = "0x17000006")]
			public ASN1 ASN1
			{
				[global::Cpp2ILInjected.Token(Token = "0x600002A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7A754", Offset = "0x1A7A754", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000288 RID: 648 RVA: 0x000036AB File Offset: 0x000018AB
			// (set) Token: 0x06000289 RID: 649 RVA: 0x000036AE File Offset: 0x000018AE
			[global::Cpp2ILInjected.Token(Token = "0x17000007")]
			public ASN1 Content
			{
				[global::Cpp2ILInjected.Token(Token = "0x600002B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7A804", Offset = "0x1A7A804", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600002C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7A80C", Offset = "0x1A7A80C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600028A RID: 650 RVA: 0x000036B1 File Offset: 0x000018B1
			// (set) Token: 0x0600028B RID: 651 RVA: 0x000036B4 File Offset: 0x000018B4
			[global::Cpp2ILInjected.Token(Token = "0x17000008")]
			public string ContentType
			{
				[global::Cpp2ILInjected.Token(Token = "0x600002D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7A814", Offset = "0x1A7A814", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600002E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7A81C", Offset = "0x1A7A81C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x0600028C RID: 652 RVA: 0x000036B7 File Offset: 0x000018B7
			[global::Cpp2ILInjected.Token(Token = "0x600002F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A758", Offset = "0x1A7A758", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal ASN1 GetASN1()
			{
				throw null;
			}

			// Token: 0x04000299 RID: 665
			[global::Cpp2ILInjected.Token(Token = "0x4000004")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string contentType;

			// Token: 0x0400029A RID: 666
			[global::Cpp2ILInjected.Token(Token = "0x4000005")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ASN1 content;
		}

		// Token: 0x02000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		public class EncryptedData
		{
			// Token: 0x0600028D RID: 653 RVA: 0x000036BA File Offset: 0x000018BA
			[global::Cpp2ILInjected.Token(Token = "0x6000030")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A824", Offset = "0x1A7A824", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EncryptedData()
			{
				throw null;
			}

			// Token: 0x0600028E RID: 654 RVA: 0x000036BD File Offset: 0x000018BD
			[global::Cpp2ILInjected.Token(Token = "0x6000031")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7A840", Offset = "0x1A7A840", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			public EncryptedData(ASN1 asn1)
			{
				throw null;
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600028F RID: 655 RVA: 0x000036C0 File Offset: 0x000018C0
			[global::Cpp2ILInjected.Token(Token = "0x17000009")]
			public PKCS7.ContentInfo EncryptionAlgorithm
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000032")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7AAB4", Offset = "0x1A7AAB4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000290 RID: 656 RVA: 0x000036C3 File Offset: 0x000018C3
			[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
			public byte[] EncryptedContent
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000033")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7AABC", Offset = "0x1A7AABC", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[] { typeof(PKCS7.EncryptedData) }, ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400029B RID: 667
			[global::Cpp2ILInjected.Token(Token = "0x4000006")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private byte _version;

			// Token: 0x0400029C RID: 668
			[global::Cpp2ILInjected.Token(Token = "0x4000007")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private PKCS7.ContentInfo _content;

			// Token: 0x0400029D RID: 669
			[global::Cpp2ILInjected.Token(Token = "0x4000008")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PKCS7.ContentInfo _encryptionAlgorithm;

			// Token: 0x0400029E RID: 670
			[global::Cpp2ILInjected.Token(Token = "0x4000009")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private byte[] _encrypted;
		}

		// Token: 0x02000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x2000009")]
		public class SignedData
		{
			// Token: 0x06000291 RID: 657 RVA: 0x000036C6 File Offset: 0x000018C6
			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7AB30", Offset = "0x1A7AB30", Length = "0x424")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.SignerInfo), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.SignerInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.SignedData), Member = "OidToName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			public SignedData(ASN1 asn1)
			{
				throw null;
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000292 RID: 658 RVA: 0x000036C9 File Offset: 0x000018C9
			[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
			public X509CertificateCollection Certificates
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000035")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B634", Offset = "0x1A7B634", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000293 RID: 659 RVA: 0x000036CC File Offset: 0x000018CC
			[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
			public PKCS7.ContentInfo ContentInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000036")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B63C", Offset = "0x1A7B63C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000AA RID: 170
			// (set) Token: 0x06000294 RID: 660 RVA: 0x000036CF File Offset: 0x000018CF
			[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
			public string HashName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000037")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B624", Offset = "0x1A7B624", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000295 RID: 661 RVA: 0x000036D2 File Offset: 0x000018D2
			[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
			public PKCS7.SignerInfo SignerInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000038")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B644", Offset = "0x1A7B644", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000296 RID: 662 RVA: 0x000036D5 File Offset: 0x000018D5
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B470", Offset = "0x1A7B470", Length = "0x1B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal string OidToName(string oid)
			{
				throw null;
			}

			// Token: 0x0400029F RID: 671
			[global::Cpp2ILInjected.Token(Token = "0x400000A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private byte version;

			// Token: 0x040002A0 RID: 672
			[global::Cpp2ILInjected.Token(Token = "0x400000B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			// Token: 0x040002A1 RID: 673
			[global::Cpp2ILInjected.Token(Token = "0x400000C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private PKCS7.ContentInfo contentInfo;

			// Token: 0x040002A2 RID: 674
			[global::Cpp2ILInjected.Token(Token = "0x400000D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private X509CertificateCollection certs;

			// Token: 0x040002A3 RID: 675
			[global::Cpp2ILInjected.Token(Token = "0x400000E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ArrayList crls;

			// Token: 0x040002A4 RID: 676
			[global::Cpp2ILInjected.Token(Token = "0x400000F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private PKCS7.SignerInfo signerInfo;

			// Token: 0x040002A5 RID: 677
			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private bool mda;
		}

		// Token: 0x0200005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		public class SignerInfo
		{
			// Token: 0x06000297 RID: 663 RVA: 0x000036D8 File Offset: 0x000018D8
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B3EC", Offset = "0x1A7B3EC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignerInfo), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public SignerInfo()
			{
				throw null;
			}

			// Token: 0x06000298 RID: 664 RVA: 0x000036DB File Offset: 0x000018DB
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B0D8", Offset = "0x1A7B0D8", Length = "0x314")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.SignedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new object[]
			{
				typeof(PKCS7.SignedData),
				typeof(byte[]),
				typeof(HashAlgorithm)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.SignerInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public SignerInfo(ASN1 asn1)
			{
				throw null;
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000299 RID: 665 RVA: 0x000036DE File Offset: 0x000018DE
			[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
			public string IssuerName
			{
				[global::Cpp2ILInjected.Token(Token = "0x600003C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B778", Offset = "0x1A7B778", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600029A RID: 666 RVA: 0x000036E1 File Offset: 0x000018E1
			[global::Cpp2ILInjected.Token(Token = "0x17000010")]
			public byte[] SerialNumber
			{
				[global::Cpp2ILInjected.Token(Token = "0x600003D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B780", Offset = "0x1A7B780", Length = "0x74")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600029B RID: 667 RVA: 0x000036E4 File Offset: 0x000018E4
			[global::Cpp2ILInjected.Token(Token = "0x17000011")]
			public ArrayList AuthenticatedAttributes
			{
				[global::Cpp2ILInjected.Token(Token = "0x600003E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B7F4", Offset = "0x1A7B7F4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600029C RID: 668 RVA: 0x000036E7 File Offset: 0x000018E7
			// (set) Token: 0x0600029D RID: 669 RVA: 0x000036EA File Offset: 0x000018EA
			[global::Cpp2ILInjected.Token(Token = "0x17000012")]
			public string HashName
			{
				[global::Cpp2ILInjected.Token(Token = "0x600003F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B7FC", Offset = "0x1A7B7FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000040")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B804", Offset = "0x1A7B804", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600029E RID: 670 RVA: 0x000036ED File Offset: 0x000018ED
			[global::Cpp2ILInjected.Token(Token = "0x17000013")]
			public byte[] Signature
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000041")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B80C", Offset = "0x1A7B80C", Length = "0x74")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x0600029F RID: 671 RVA: 0x000036F0 File Offset: 0x000018F0
			[global::Cpp2ILInjected.Token(Token = "0x17000014")]
			public ArrayList UnauthenticatedAttributes
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000042")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B880", Offset = "0x1A7B880", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x000036F3 File Offset: 0x000018F3
			[global::Cpp2ILInjected.Token(Token = "0x17000015")]
			public byte Version
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000043")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7B888", Offset = "0x1A7B888", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040002A6 RID: 678
			[global::Cpp2ILInjected.Token(Token = "0x4000011")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private byte version;

			// Token: 0x040002A7 RID: 679
			[global::Cpp2ILInjected.Token(Token = "0x4000012")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			// Token: 0x040002A8 RID: 680
			[global::Cpp2ILInjected.Token(Token = "0x4000013")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private ArrayList authenticatedAttributes;

			// Token: 0x040002A9 RID: 681
			[global::Cpp2ILInjected.Token(Token = "0x4000014")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ArrayList unauthenticatedAttributes;

			// Token: 0x040002AA RID: 682
			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private byte[] signature;

			// Token: 0x040002AB RID: 683
			[global::Cpp2ILInjected.Token(Token = "0x4000016")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string issuer;

			// Token: 0x040002AC RID: 684
			[global::Cpp2ILInjected.Token(Token = "0x4000017")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private byte[] serial;

			// Token: 0x040002AD RID: 685
			[global::Cpp2ILInjected.Token(Token = "0x4000018")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private byte[] ski;
		}
	}
}
