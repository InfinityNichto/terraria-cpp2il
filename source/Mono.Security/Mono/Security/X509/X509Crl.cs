using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;
using Mono.Security.X509.Extensions;

namespace Mono.Security.X509
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public class X509Crl
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000030AB File Offset: 0x000012AB
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8B588", Offset = "0x1A8B588", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "CreateFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "LoadCrl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public X509Crl(byte[] crl)
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000030AE File Offset: 0x000012AE
		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8B67C", Offset = "0x1A8B67C", Length = "0x5D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToDateTime", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl.X509CrlEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		private void Parse(byte[] crl)
		{
			throw null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000030B1 File Offset: 0x000012B1
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public ArrayList Entries
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BD20", Offset = "0x1A8BD20", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = "ReadOnly", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(ArrayList))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public X509Crl.X509CrlEntry this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BD2C", Offset = "0x1A8BD2C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public X509Crl.X509CrlEntry this[byte[] serialNumber]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BDBC", Offset = "0x1A8BDBC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000030BA File Offset: 0x000012BA
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public X509ExtensionCollection Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BF0C", Offset = "0x1A8BF0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000030BD File Offset: 0x000012BD
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public byte[] Hash
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BF14", Offset = "0x1A8BF14", Length = "0x1F8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "CreateFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000030C0 File Offset: 0x000012C0
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public string IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C10C", Offset = "0x1A8C10C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000030C3 File Offset: 0x000012C3
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public DateTime NextUpdate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C114", Offset = "0x1A8C114", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000030C6 File Offset: 0x000012C6
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public DateTime ThisUpdate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C11C", Offset = "0x1A8C11C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000030C9 File Offset: 0x000012C9
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C124", Offset = "0x1A8C124", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000030CC File Offset: 0x000012CC
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public byte[] Signature
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C12C", Offset = "0x1A8C12C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000030CF File Offset: 0x000012CF
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C1A0", Offset = "0x1A8C1A0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000030D2 File Offset: 0x000012D2
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public byte Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C210", Offset = "0x1A8C210", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000030D5 File Offset: 0x000012D5
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public bool IsCurrent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8C218", Offset = "0x1A8C218", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000030D8 File Offset: 0x000012D8
		[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C278", Offset = "0x1A8C278", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool WasCurrent(DateTime instant)
		{
			throw null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000030DB File Offset: 0x000012DB
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C35C", Offset = "0x1A8C35C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000030DE File Offset: 0x000012DE
		[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C3CC", Offset = "0x1A8C3CC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Crl.X509CrlEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool Compare(byte[] array1, byte[] array2)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000030E1 File Offset: 0x000012E1
		[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C430", Offset = "0x1A8C430", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Crl.X509CrlEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			throw null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000030E4 File Offset: 0x000012E4
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8BDC0", Offset = "0x1A8BDC0", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Crl.X509CrlEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl.X509CrlEntry), Member = "get_SerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "Compare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000030E7 File Offset: 0x000012E7
		[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C51C", Offset = "0x1A8C51C", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyUsageExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyUsageExtension), Member = "Support", MemberParameters = new object[] { typeof(KeyUsages) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool VerifySignature(X509Certificate x509)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000030EA File Offset: 0x000012EA
		[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C738", Offset = "0x1A8C738", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSASignatureDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal bool VerifySignature(DSA dsa)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000030ED File Offset: 0x000012ED
		[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8C9E8", Offset = "0x1A8C9E8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAPKCS1SignatureDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal bool VerifySignature(RSA rsa)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000030F0 File Offset: 0x000012F0
		[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8CAB4", Offset = "0x1A8CAB4", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000030F3 File Offset: 0x000012F3
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8CC28", Offset = "0x1A8CC28", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static X509Crl CreateFromFile(string filename)
		{
			throw null;
		}

		// Token: 0x0400003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string issuer;

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x400005D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte version;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTime thisUpdate;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DateTime nextUpdate;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ArrayList entries;

		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string signatureOID;

		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] signature;

		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private X509ExtensionCollection extensions;

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] encoded;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] hash_value;

		// Token: 0x0200005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x2000014")]
		public class X509CrlEntry
		{
			// Token: 0x060002B0 RID: 688 RVA: 0x00003723 File Offset: 0x00001923
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8CE4C", Offset = "0x1A8CE4C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal X509CrlEntry(byte[] serialNumber, DateTime revocationDate, X509ExtensionCollection extensions)
			{
				throw null;
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x00003726 File Offset: 0x00001926
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8BC54", Offset = "0x1A8BC54", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "Parse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToDateTime", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal X509CrlEntry(ASN1 entry)
			{
				throw null;
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x00003729 File Offset: 0x00001929
			[global::Cpp2ILInjected.Token(Token = "0x17000031")]
			public byte[] SerialNumber
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A8C4AC", Offset = "0x1A8C4AC", Length = "0x70")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Crl.X509CrlEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000372C File Offset: 0x0000192C
			[global::Cpp2ILInjected.Token(Token = "0x17000032")]
			public DateTime RevocationDate
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A8CECC", Offset = "0x1A8CECC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000372F File Offset: 0x0000192F
			[global::Cpp2ILInjected.Token(Token = "0x17000033")]
			public X509ExtensionCollection Extensions
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A8CED4", Offset = "0x1A8CED4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x00003732 File Offset: 0x00001932
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8CEDC", Offset = "0x1A8CEDC", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromDateTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public byte[] GetBytes()
			{
				throw null;
			}

			// Token: 0x040002B5 RID: 693
			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private byte[] sn;

			// Token: 0x040002B6 RID: 694
			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private DateTime revocationDate;

			// Token: 0x040002B7 RID: 695
			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private X509ExtensionCollection extensions;
		}
	}
}
