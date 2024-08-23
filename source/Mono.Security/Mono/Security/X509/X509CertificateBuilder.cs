using System;
using System.Collections;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x0200000F RID: 15
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public class X509CertificateBuilder : X509Builder
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00003168 File Offset: 0x00001368
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8FCA4", Offset = "0x1A8FCA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public X509CertificateBuilder()
		{
			throw null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000316B File Offset: 0x0000136B
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8FCAC", Offset = "0x1A8FCAC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Builder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public X509CertificateBuilder(byte version)
		{
			throw null;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000316E File Offset: 0x0000136E
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00003171 File Offset: 0x00001371
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public byte Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD74", Offset = "0x1A8FD74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD7C", Offset = "0x1A8FD7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003174 File Offset: 0x00001374
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00003177 File Offset: 0x00001377
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public byte[] SerialNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD84", Offset = "0x1A8FD84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD8C", Offset = "0x1A8FD8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000317A File Offset: 0x0000137A
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000317D File Offset: 0x0000137D
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public string IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD94", Offset = "0x1A8FD94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FD9C", Offset = "0x1A8FD9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00003183 File Offset: 0x00001383
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		public DateTime NotBefore
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDA4", Offset = "0x1A8FDA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDAC", Offset = "0x1A8FDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003186 File Offset: 0x00001386
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003189 File Offset: 0x00001389
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public DateTime NotAfter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDB4", Offset = "0x1A8FDB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDBC", Offset = "0x1A8FDBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000318C File Offset: 0x0000138C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000318F File Offset: 0x0000138F
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public string SubjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDC4", Offset = "0x1A8FDC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDCC", Offset = "0x1A8FDCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003192 File Offset: 0x00001392
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00003195 File Offset: 0x00001395
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public AsymmetricAlgorithm SubjectPublicKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDD4", Offset = "0x1A8FDD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDDC", Offset = "0x1A8FDDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000319B File Offset: 0x0000139B
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public byte[] IssuerUniqueId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDE4", Offset = "0x1A8FDE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDEC", Offset = "0x1A8FDEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000319E File Offset: 0x0000139E
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000031A1 File Offset: 0x000013A1
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public byte[] SubjectUniqueId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDF4", Offset = "0x1A8FDF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FDFC", Offset = "0x1A8FDFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000031A4 File Offset: 0x000013A4
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public X509ExtensionCollection Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8FE04", Offset = "0x1A8FE04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000031A7 File Offset: 0x000013A7
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8FE0C", Offset = "0x1A8FE0C", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ASN1)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateBuilder), Member = "UniqueIdentifier", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private ASN1 SubjectPublicKeyInfo()
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000031AA File Offset: 0x000013AA
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90170", Offset = "0x1A90170", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "SubjectPublicKeyInfo", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] UniqueIdentifier(byte[] id)
		{
			throw null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000031AD File Offset: 0x000013AD
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90230", Offset = "0x1A90230", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X501), Member = "FromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromDateTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateBuilder), Member = "SubjectPublicKeyInfo", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateBuilder), Member = "UniqueIdentifier", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected override ASN1 ToBeSigned(string oid)
		{
			throw null;
		}

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte version;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] sn;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string issuer;

		// Token: 0x04000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private DateTime notBefore;

		// Token: 0x04000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DateTime notAfter;

		// Token: 0x04000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string subject;

		// Token: 0x04000066 RID: 102
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private AsymmetricAlgorithm aa;

		// Token: 0x04000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] issuerUniqueID;

		// Token: 0x04000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] subjectUniqueID;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private X509ExtensionCollection extensions;
	}
}
