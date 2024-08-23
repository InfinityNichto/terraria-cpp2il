using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509.Extensions;

namespace Mono.Security.X509
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public class X509Store
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00003279 File Offset: 0x00001479
		[global::Cpp2ILInjected.Token(Token = "0x600014D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93188", Offset = "0x1A93188", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal X509Store(string path, bool crl, bool newFormat)
		{
			throw null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000327C File Offset: 0x0000147C
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public X509CertificateCollection Certificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A931C8", Offset = "0x1A931C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000327F File Offset: 0x0000147F
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public ArrayList Crls
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A933B4", Offset = "0x1A933B4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckCrls", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(X509Store)
			}, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00003282 File Offset: 0x00001482
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A935E8", Offset = "0x1A935E8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003285 File Offset: 0x00001485
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93674", Offset = "0x1A93674", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Stores), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003288 File Offset: 0x00001488
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A936B4", Offset = "0x1A936B4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		private void ClearCertificates()
		{
			throw null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000328B File Offset: 0x0000148B
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A936D8", Offset = "0x1A936D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ClearCrls()
		{
			throw null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000328E File Offset: 0x0000148E
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93704", Offset = "0x1A93704", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "ImportNewFormat", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void Import(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003291 File Offset: 0x00001491
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A941C8", Offset = "0x1A941C8", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "get_RawData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Import(X509Crl crl)
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003294 File Offset: 0x00001494
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A944D4", Offset = "0x1A944D4", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Remove(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003297 File Offset: 0x00001497
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A948A0", Offset = "0x1A948A0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove(X509Crl crl)
		{
			throw null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000329A File Offset: 0x0000149A
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93C98", Offset = "0x1A93C98", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetSubjectNameHash", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "ExportAsPEM", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void ImportNewFormat(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000329D File Offset: 0x0000149D
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94614", Offset = "0x1A94614", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetSubjectNameHash", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void RemoveNewFormat(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000032A0 File Offset: 0x000014A0
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94120", Offset = "0x1A94120", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		private string GetUniqueNameWithSerial(X509Certificate certificate)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000032A3 File Offset: 0x000014A3
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94080", Offset = "0x1A94080", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Remove", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueNameWithSerial", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509ExtensionCollection),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string GetUniqueName(X509Certificate certificate, byte[] serial = null)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000032A6 File Offset: 0x000014A6
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94438", Offset = "0x1A94438", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Remove", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509ExtensionCollection),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string GetUniqueName(X509Crl crl)
		{
			throw null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000032A9 File Offset: 0x000014A9
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94998", Offset = "0x1A94998", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SubjectKeyIdentifierExtension), Member = "get_Identifier", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] GetUniqueName(X509ExtensionCollection extensions, byte[] serial = null)
		{
			throw null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000032AC File Offset: 0x000014AC
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94AB4", Offset = "0x1A94AB4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(byte[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "GetUniqueName", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private string GetUniqueName(string method, byte[] name, string fileExtension)
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000032AF File Offset: 0x000014AF
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94C7C", Offset = "0x1A94C7C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "LoadCrl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private byte[] Load(string filename)
		{
			throw null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000032B2 File Offset: 0x000014B2
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9415C", Offset = "0x1A9415C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private X509Certificate LoadCertificate(string filename)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000032B5 File Offset: 0x000014B5
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94E6C", Offset = "0x1A94E6C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private X509Crl LoadCrl(string filename)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000032B8 File Offset: 0x000014B8
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A93BBC", Offset = "0x1A93BBC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Import", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "BuildCrlsCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool CheckStore(string path, bool throwException)
		{
			throw null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000032BB File Offset: 0x000014BB
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A931F0", Offset = "0x1A931F0", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_UntrustedCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000032BE File Offset: 0x000014BE
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9343C", Offset = "0x1A9343C", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "CheckStore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "LoadCrl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private ArrayList BuildCrlsCollection(string storeName)
		{
			throw null;
		}

		// Token: 0x0400007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _storePath;

		// Token: 0x0400007C RID: 124
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private X509CertificateCollection _certificates;

		// Token: 0x0400007D RID: 125
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ArrayList _crls;

		// Token: 0x0400007E RID: 126
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _crl;

		// Token: 0x0400007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _newFormat;

		// Token: 0x04000080 RID: 128
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _name;
	}
}
