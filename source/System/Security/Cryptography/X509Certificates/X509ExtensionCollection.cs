using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BA RID: 186
	[global::Cpp2ILInjected.Token(Token = "0x2000118")]
	public sealed class X509ExtensionCollection : ICollection, IEnumerable
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00003F1D File Offset: 0x0000211D
		[global::Cpp2ILInjected.Token(Token = "0x6000699")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDCA90", Offset = "0x1EDCA90", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509ExtensionCollection()
		{
			throw null;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00003F20 File Offset: 0x00002120
		[global::Cpp2ILInjected.Token(Token = "0x1700016D")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDCAF4", Offset = "0x1EDCAF4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00003F23 File Offset: 0x00002123
		[global::Cpp2ILInjected.Token(Token = "0x1700016E")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDCB08", Offset = "0x1EDCB08", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00003F26 File Offset: 0x00002126
		[global::Cpp2ILInjected.Token(Token = "0x1700016F")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDCB1C", Offset = "0x1EDCB1C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x17000170")]
		public X509Extension this[string oid]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDCB20", Offset = "0x1EDCB20", Length = "0x370")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
			{
				typeof(X509FindType),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00003F2C File Offset: 0x0000212C
		[global::Cpp2ILInjected.Token(Token = "0x600069E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDCE90", Offset = "0x1EDCE90", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int Add(X509Extension extension)
		{
			throw null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003F2F File Offset: 0x0000212F
		[global::Cpp2ILInjected.Token(Token = "0x600069F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDCEF8", Offset = "0x1EDCEF8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00003F32 File Offset: 0x00002132
		[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDCFE8", Offset = "0x1EDCFE8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509ExtensionEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00003F35 File Offset: 0x00002135
		[global::Cpp2ILInjected.Token(Token = "0x60006A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD098", Offset = "0x1EDD098", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00003F38 File Offset: 0x00002138
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD10C", Offset = "0x1EDD10C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static X509ExtensionCollection()
		{
			throw null;
		}

		// Token: 0x040003C2 RID: 962
		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		private static byte[] Empty;

		// Token: 0x040003C3 RID: 963
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
