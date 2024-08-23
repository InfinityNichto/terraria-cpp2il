using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BB RID: 187
	[global::Cpp2ILInjected.Token(Token = "0x2000119")]
	public sealed class X509ExtensionEnumerator : IEnumerator
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00003F3B File Offset: 0x0000213B
		[global::Cpp2ILInjected.Token(Token = "0x60006A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD05C", Offset = "0x1EDD05C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal X509ExtensionEnumerator(ArrayList list)
		{
			throw null;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00003F3E File Offset: 0x0000213E
		[global::Cpp2ILInjected.Token(Token = "0x17000171")]
		public X509Extension Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDD174", Offset = "0x1EDD174", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00003F41 File Offset: 0x00002141
		[global::Cpp2ILInjected.Token(Token = "0x17000172")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDD25C", Offset = "0x1EDD25C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00003F44 File Offset: 0x00002144
		[global::Cpp2ILInjected.Token(Token = "0x60006A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD2F8", Offset = "0x1EDD2F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00003F47 File Offset: 0x00002147
		[global::Cpp2ILInjected.Token(Token = "0x60006A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDD390", Offset = "0x1EDD390", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x040003C4 RID: 964
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
