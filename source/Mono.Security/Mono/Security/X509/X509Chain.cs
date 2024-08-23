using System;
using System.Collections;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;

namespace Mono.Security.X509
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	public class X509Chain
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x000031E3 File Offset: 0x000013E3
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A910C0", Offset = "0x1A910C0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509Chain()
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000031E6 File Offset: 0x000013E6
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91124", Offset = "0x1A91124", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509Chain(X509CertificateCollection chain)
		{
			throw null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000031E9 File Offset: 0x000013E9
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public X509CertificateCollection Chain
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A91198", Offset = "0x1A91198", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000031EC File Offset: 0x000013EC
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public X509Certificate Root
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A911A0", Offset = "0x1A911A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000031EF File Offset: 0x000013EF
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public X509ChainStatusFlags Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A911A8", Offset = "0x1A911A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000031F2 File Offset: 0x000013F2
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000031F5 File Offset: 0x000013F5
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public X509CertificateCollection TrustAnchors
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000120")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A911B0", Offset = "0x1A911B0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsTrusted", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(X509Certificate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000121")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A912D0", Offset = "0x1A912D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000031F8 File Offset: 0x000013F8
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A912D8", Offset = "0x1A912D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		public void LoadCertificate(X509Certificate x509)
		{
			throw null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000031FB File Offset: 0x000013FB
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A912E0", Offset = "0x1A912E0", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		public void LoadCertificates(X509CertificateCollection collection)
		{
			throw null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000031FE File Offset: 0x000013FE
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A912E8", Offset = "0x1A912E8", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public X509Certificate FindByIssuerName(string issuerName)
		{
			throw null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003201 File Offset: 0x00001401
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A914D0", Offset = "0x1A914D0", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Certificate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "IsValid", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool Build(X509Certificate leaf)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003204 File Offset: 0x00001404
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91E54", Offset = "0x1A91E54", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003207 File Offset: 0x00001407
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91DAC", Offset = "0x1A91DAC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_IsCurrent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool IsValid(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000320A File Offset: 0x0000140A
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91858", Offset = "0x1A91858", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Certificate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private X509Certificate FindCertificateParent(X509Certificate child)
		{
			throw null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000320D File Offset: 0x0000140D
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91A34", Offset = "0x1A91A34", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Certificate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			throw null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003210 File Offset: 0x00001410
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91E8C", Offset = "0x1A91E8C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		private bool IsTrusted(X509Certificate potentialTrusted)
		{
			throw null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003213 File Offset: 0x00001413
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A91C70", Offset = "0x1A91C70", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool IsParent(X509Certificate child, X509Certificate parent)
		{
			throw null;
		}

		// Token: 0x0400006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509CertificateCollection roots;

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private X509CertificateCollection certs;

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Certificate _root;

		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _chain;

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509ChainStatusFlags _status;
	}
}
