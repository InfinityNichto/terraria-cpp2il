using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B2 RID: 178
	[global::Cpp2ILInjected.Token(Token = "0x2000110")]
	public sealed class X509ChainElementCollection : ICollection, IEnumerable
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x00003E1E File Offset: 0x0000201E
		[global::Cpp2ILInjected.Token(Token = "0x600063E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED877C", Offset = "0x1ED877C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal X509ChainElementCollection()
		{
			throw null;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00003E21 File Offset: 0x00002021
		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600063F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED87E0", Offset = "0x1ED87E0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00003E24 File Offset: 0x00002024
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000640")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED87F4", Offset = "0x1ED87F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public unsafe X509ChainElement this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000641")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8808", Offset = "0x1ED8808", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list_ref),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocationOnChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00003E2A File Offset: 0x0000202A
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000642")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8898", Offset = "0x1ED8898", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00003E2D File Offset: 0x0000202D
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED88AC", Offset = "0x1ED88AC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00003E30 File Offset: 0x00002030
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED88C0", Offset = "0x1ED88C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509ChainElementEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00003E33 File Offset: 0x00002033
		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED89D0", Offset = "0x1ED89D0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00003E36 File Offset: 0x00002036
		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8A2C", Offset = "0x1ED8A2C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElement), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void Add(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00003E39 File Offset: 0x00002039
		[global::Cpp2ILInjected.Token(Token = "0x6000647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8AA4", Offset = "0x1ED8AA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Clear()
		{
			throw null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00003E3C File Offset: 0x0000203C
		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8AB8", Offset = "0x1ED8AB8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool Contains(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x040003A2 RID: 930
		[global::Cpp2ILInjected.Token(Token = "0x400050C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
