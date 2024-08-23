using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x02000014 RID: 20
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00003246 File Offset: 0x00001446
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8FD6C", Offset = "0x1A8FD6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl.X509CrlEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DateTime),
			typeof(X509ExtensionCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509ExtensionCollection()
		{
			throw null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003249 File Offset: 0x00001449
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A928AC", Offset = "0x1A928AC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl.X509CrlEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "Parse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "Parse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public X509ExtensionCollection(ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000324C File Offset: 0x0000144C
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A929E0", Offset = "0x1A929E0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int Add(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000324F File Offset: 0x0000144F
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92A84", Offset = "0x1A92A84", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void AddRange(X509Extension[] extension)
		{
			throw null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003252 File Offset: 0x00001452
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92B6C", Offset = "0x1A92B6C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void AddRange(X509ExtensionCollection collection)
		{
			throw null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003255 File Offset: 0x00001455
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92D10", Offset = "0x1A92D10", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(int))]
		public bool Contains(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003258 File Offset: 0x00001458
		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92E60", Offset = "0x1A92E60", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		public bool Contains(string oid)
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000325B File Offset: 0x0000145B
		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92FB8", Offset = "0x1A92FB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void CopyTo(X509Extension[] extensions, int index)
		{
			throw null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000325E File Offset: 0x0000145E
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92D28", Offset = "0x1A92D28", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "Contains", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int IndexOf(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003261 File Offset: 0x00001461
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A92E78", Offset = "0x1A92E78", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int IndexOf(string oid)
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003264 File Offset: 0x00001464
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93020", Offset = "0x1A93020", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Insert(int index, X509Extension extension)
		{
			throw null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003267 File Offset: 0x00001467
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93088", Offset = "0x1A93088", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000326A File Offset: 0x0000146A
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A930F0", Offset = "0x1A930F0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove(string oid)
		{
			throw null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000326D File Offset: 0x0000146D
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93174", Offset = "0x1A93174", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000046 RID: 70
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public X509Extension this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A92C80", Offset = "0x1A92C80", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ExtensionCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509ExtensionCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000047 RID: 71
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public X509Extension this[string oid]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A91EB0", Offset = "0x1A91EB0", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				typeof(X509Certificate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
			{
				typeof(X509ExtensionCollection),
				typeof(byte[])
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003276 File Offset: 0x00001476
		[global::Cpp2ILInjected.Token(Token = "0x600014C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A90554", Offset = "0x1A90554", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl.X509CrlEntry), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = "get_ASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool readOnly;
	}
}
