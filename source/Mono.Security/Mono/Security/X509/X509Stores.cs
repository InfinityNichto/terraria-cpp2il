using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x02000017 RID: 23
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public class X509Stores
	{
		// Token: 0x06000139 RID: 313 RVA: 0x000032EB File Offset: 0x000014EB
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A95330", Offset = "0x1A95330", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal X509Stores(string path, bool newFormat)
		{
			throw null;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000032EE File Offset: 0x000014EE
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public X509Store Personal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000174")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95A38", Offset = "0x1A95A38", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000032F1 File Offset: 0x000014F1
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public X509Store OtherPeople
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000175")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95B00", Offset = "0x1A95B00", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000032F4 File Offset: 0x000014F4
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public X509Store IntermediateCA
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000176")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A955DC", Offset = "0x1A955DC", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000032F7 File Offset: 0x000014F7
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public X509Store TrustedRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9574C", Offset = "0x1A9574C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000032FA File Offset: 0x000014FA
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public X509Store Untrusted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000178")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95968", Offset = "0x1A95968", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_UntrustedCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000032FD File Offset: 0x000014FD
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A95BC8", Offset = "0x1A95BC8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Clear", ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003300 File Offset: 0x00001500
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A95C28", Offset = "0x1A95C28", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public X509Store Open(string storeName, bool create)
		{
			throw null;
		}

		// Token: 0x04000089 RID: 137
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _storePath;

		// Token: 0x0400008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _newFormat;

		// Token: 0x0400008B RID: 139
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Store _personal;

		// Token: 0x0400008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509Store _other;

		// Token: 0x0400008D RID: 141
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509Store _intermediate;

		// Token: 0x0400008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private X509Store _trusted;

		// Token: 0x0400008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private X509Store _untrusted;

		// Token: 0x0200005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		public class Names
		{
			// Token: 0x060002BD RID: 701 RVA: 0x0000374A File Offset: 0x0000194A
			[global::Cpp2ILInjected.Token(Token = "0x600017B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95D3C", Offset = "0x1A95D3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Names()
			{
				throw null;
			}

			// Token: 0x040002B9 RID: 697
			[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
			public const string Personal = "My";

			// Token: 0x040002BA RID: 698
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			public const string OtherPeople = "AddressBook";

			// Token: 0x040002BB RID: 699
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			public const string IntermediateCA = "CA";

			// Token: 0x040002BC RID: 700
			[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
			public const string TrustedRoot = "Trust";

			// Token: 0x040002BD RID: 701
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			public const string Untrusted = "Disallowed";
		}
	}
}
