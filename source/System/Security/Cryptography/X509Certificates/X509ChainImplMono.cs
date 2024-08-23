using System;
using System.Collections;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509;
using Mono.Security.X509.Extensions;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B5 RID: 181
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	internal class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00003E5D File Offset: 0x0000205D
		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8F44", Offset = "0x1ED8F44", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Helper2), Member = "CreateChainImpl", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(X509ChainImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509ChainImplMono(bool useMachineContext)
		{
			throw null;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00003E60 File Offset: 0x00002060
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		public override bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600065A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9010", Offset = "0x1ED9010", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00003E63 File Offset: 0x00002063
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		public override X509ChainElementCollection ChainElements
		{
			[global::Cpp2ILInjected.Token(Token = "0x600065B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9018", Offset = "0x1ED9018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00003E66 File Offset: 0x00002066
		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		public override X509ChainPolicy ChainPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600065C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9020", Offset = "0x1ED9020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00003E69 File Offset: 0x00002069
		[global::Cpp2ILInjected.Token(Token = "0x600065D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED9028", Offset = "0x1ED9028", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void AddStatus(X509ChainStatusFlags error)
		{
			throw null;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00003E6C File Offset: 0x0000206C
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		[global::Cpp2ILInjected.Token(Token = "0x600065E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED902C", Offset = "0x1ED902C", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "GetEnumerator", ReturnType = typeof(X509ChainElementEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementEnumerator), Member = "get_Current", ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override bool Build(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00003E6F File Offset: 0x0000206F
		[global::Cpp2ILInjected.Token(Token = "0x600065F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED9750", Offset = "0x1ED9750", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Close", ReturnType = typeof(void))]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00003E72 File Offset: 0x00002072
		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		private X509Certificate2Collection Roots
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000660")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9808", Offset = "0x1ED9808", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "AddRange", MemberParameters = new object[] { typeof(X509Certificate2Collection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00003E75 File Offset: 0x00002075
		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		private X509Certificate2Collection CertificateAuthorities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000661")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9A90", Offset = "0x1ED9A90", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "AddRange", MemberParameters = new object[] { typeof(X509Certificate2Collection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00003E78 File Offset: 0x00002078
		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		private X509Store LMRootStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000662")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED98B8", Offset = "0x1ED98B8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(StoreName),
				typeof(StoreLocation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00003E7B File Offset: 0x0000207B
		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		private X509Store UserRootStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000663")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED99A4", Offset = "0x1ED99A4", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(StoreName),
				typeof(StoreLocation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00003E7E File Offset: 0x0000207E
		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		private X509Store LMCAStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000664")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9B40", Offset = "0x1ED9B40", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(StoreName),
				typeof(StoreLocation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00003E81 File Offset: 0x00002081
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		private X509Store UserCAStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000665")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9C2C", Offset = "0x1ED9C2C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(StoreName),
				typeof(StoreLocation)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00003E84 File Offset: 0x00002084
		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		private X509Certificate2Collection CertificateCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000666")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9D18", Offset = "0x1ED9D18", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "AddRange", MemberParameters = new object[] { typeof(X509Certificate2Collection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00003E87 File Offset: 0x00002087
		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED9574", Offset = "0x1ED9574", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "Contains", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "Contains", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003E8A File Offset: 0x0000208A
		[global::Cpp2ILInjected.Token(Token = "0x6000668")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA1D0", Offset = "0x1EDA1D0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
		{
			typeof(X509FindType),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
		{
			throw null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00003E8D File Offset: 0x0000208D
		[global::Cpp2ILInjected.Token(Token = "0x6000669")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA010", Offset = "0x1EDA010", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new object[]
		{
			typeof(X509FindType),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "AddRange", MemberParameters = new object[] { typeof(X509Certificate2Collection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2Collection)
		}, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private X509Certificate2 FindParent(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00003E90 File Offset: 0x00002090
		[global::Cpp2ILInjected.Token(Token = "0x600066A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA110", Offset = "0x1EDA110", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsChainComplete(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00003E93 File Offset: 0x00002093
		[global::Cpp2ILInjected.Token(Token = "0x600066B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA488", Offset = "0x1EDA488", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private bool IsSelfIssued(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00003E96 File Offset: 0x00002096
		[global::Cpp2ILInjected.Token(Token = "0x600066C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED963C", Offset = "0x1ED963C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocationOnChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
		private void ValidateChain(X509ChainStatusFlags flag)
		{
			throw null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00003E99 File Offset: 0x00002099
		[global::Cpp2ILInjected.Token(Token = "0x600066D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA4C8", Offset = "0x1EDA4C8", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new object[]
		{
			typeof(X500DistinguishedName),
			typeof(X500DistinguishedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Process(int n)
		{
			throw null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00003E9C File Offset: 0x0000209C
		[global::Cpp2ILInjected.Token(Token = "0x600066E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA748", Offset = "0x1EDA748", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "get_CertificateAuthority", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "get_HasPathLengthConstraint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "get_PathLengthConstraint", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PrepareForNextCertificate(int n)
		{
			throw null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00003E9F File Offset: 0x0000209F
		[global::Cpp2ILInjected.Token(Token = "0x600066F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAAF0", Offset = "0x1EDAAF0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new object[] { typeof(X509ChainElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
		private void WrapUp()
		{
			throw null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00003EA2 File Offset: 0x000020A2
		[global::Cpp2ILInjected.Token(Token = "0x6000670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAB98", Offset = "0x1EDAB98", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "GetEnumerator", ReturnType = typeof(X509ExtensionEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionEnumerator), Member = "get_Current", ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ProcessCertificateExtensions(X509ChainElement element)
		{
			throw null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00003EA5 File Offset: 0x000020A5
		[global::Cpp2ILInjected.Token(Token = "0x6000671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAB68", Offset = "0x1EDAB68", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(bool))]
		private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
		{
			throw null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00003EA8 File Offset: 0x000020A8
		[global::Cpp2ILInjected.Token(Token = "0x6000672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA3DC", Offset = "0x1EDA3DC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2Collection)
		}, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "get_SubjectKeyIdentifier", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string GetSubjectKeyIdentifier(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00003EAB File Offset: 0x000020AB
		[global::Cpp2ILInjected.Token(Token = "0x6000673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA348", Offset = "0x1EDA348", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2Collection)
		}, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindParent", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00003EAE File Offset: 0x000020AE
		[global::Cpp2ILInjected.Token(Token = "0x6000674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDADB4", Offset = "0x1EDADB4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckCrls", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(X509Store)
		}, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string GetAuthorityKeyIdentifier(X509Crl crl)
		{
			throw null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00003EB1 File Offset: 0x000020B1
		[global::Cpp2ILInjected.Token(Token = "0x6000675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAC74", Offset = "0x1EDAC74", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthorityKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[] { typeof(X509Extension) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthorityKeyIdentifierExtension), Member = "get_Identifier", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string GetAuthorityKeyIdentifier(X509Extension ext)
		{
			throw null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00003EB4 File Offset: 0x000020B4
		[global::Cpp2ILInjected.Token(Token = "0x6000676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDA930", Offset = "0x1EDA930", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckRevocationOnChain(X509ChainStatusFlags flag)
		{
			throw null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00003EB7 File Offset: 0x000020B7
		[global::Cpp2ILInjected.Token(Token = "0x6000677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAE3C", Offset = "0x1EDAE3C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocationOnChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "IsSelfIssued", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
		{
			throw null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00003EBA File Offset: 0x000020BA
		[global::Cpp2ILInjected.Token(Token = "0x6000678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDAEF4", Offset = "0x1EDAEF4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PublicKey), Member = "get_Key", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "VerifySignature", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Crl), Member = "GetCrlEntry", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509Crl.X509CrlEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCrlEntryExtensions", MemberParameters = new object[] { typeof(X509Crl.X509CrlEntry) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "ProcessCrlExtensions", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
		{
			throw null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003EBD File Offset: 0x000020BD
		[global::Cpp2ILInjected.Token(Token = "0x6000679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDB824", Offset = "0x1EDB824", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { typeof(X509Crl) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static X509Crl CheckCrls(string subject, string ski, X509Store store)
		{
			throw null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00003EC0 File Offset: 0x000020C0
		[global::Cpp2ILInjected.Token(Token = "0x600067A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDB0B4", Offset = "0x1EDB0B4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new object[] { typeof(X500DistinguishedNameFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "CheckCrls", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(X509Store)
		}, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private X509Crl FindCrl(X509Certificate2 caCertificate)
		{
			throw null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00003EC3 File Offset: 0x000020C3
		[global::Cpp2ILInjected.Token(Token = "0x600067B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDB4FC", Offset = "0x1EDB4FC", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private bool ProcessCrlExtensions(X509Crl crl)
		{
			throw null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00003EC6 File Offset: 0x000020C6
		[global::Cpp2ILInjected.Token(Token = "0x600067C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDB20C", Offset = "0x1EDB20C", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2),
			typeof(bool)
		}, ReturnType = typeof(X509ChainStatusFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
		{
			throw null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00003EC9 File Offset: 0x000020C9
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600067D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBB90", Offset = "0x1EDBB90", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static X509ChainImplMono()
		{
			throw null;
		}

		// Token: 0x040003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x400050E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private StoreLocation location;

		// Token: 0x040003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x400050F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private X509ChainElementCollection elements;

		// Token: 0x040003A6 RID: 934
		[global::Cpp2ILInjected.Token(Token = "0x4000510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509ChainPolicy policy;

		// Token: 0x040003A7 RID: 935
		[global::Cpp2ILInjected.Token(Token = "0x4000511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509ChainStatus[] status;

		// Token: 0x040003A8 RID: 936
		[global::Cpp2ILInjected.Token(Token = "0x4000512")]
		private static X509ChainStatus[] Empty;

		// Token: 0x040003A9 RID: 937
		[global::Cpp2ILInjected.Token(Token = "0x4000513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int max_path_length;

		// Token: 0x040003AA RID: 938
		[global::Cpp2ILInjected.Token(Token = "0x4000514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private X500DistinguishedName working_issuer_name;

		// Token: 0x040003AB RID: 939
		[global::Cpp2ILInjected.Token(Token = "0x4000515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private AsymmetricAlgorithm working_public_key;

		// Token: 0x040003AC RID: 940
		[global::Cpp2ILInjected.Token(Token = "0x4000516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private X509ChainElement bce_restriction;

		// Token: 0x040003AD RID: 941
		[global::Cpp2ILInjected.Token(Token = "0x4000517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private X509Certificate2Collection roots;

		// Token: 0x040003AE RID: 942
		[global::Cpp2ILInjected.Token(Token = "0x4000518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private X509Certificate2Collection cas;

		// Token: 0x040003AF RID: 943
		[global::Cpp2ILInjected.Token(Token = "0x4000519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private X509Store root_store;

		// Token: 0x040003B0 RID: 944
		[global::Cpp2ILInjected.Token(Token = "0x400051A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private X509Store ca_store;

		// Token: 0x040003B1 RID: 945
		[global::Cpp2ILInjected.Token(Token = "0x400051B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private X509Store user_root_store;

		// Token: 0x040003B2 RID: 946
		[global::Cpp2ILInjected.Token(Token = "0x400051C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private X509Store user_ca_store;

		// Token: 0x040003B3 RID: 947
		[global::Cpp2ILInjected.Token(Token = "0x400051D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private X509Certificate2Collection collection;
	}
}
