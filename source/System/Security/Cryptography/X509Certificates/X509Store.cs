using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BE RID: 190
	[global::Cpp2ILInjected.Token(Token = "0x200011C")]
	public sealed class X509Store : IDisposable
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00003F7A File Offset: 0x0000217A
		[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE2C4", Offset = "0x1EDE2C4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
			throw null;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00003F7D File Offset: 0x0000217D
		[global::Cpp2ILInjected.Token(Token = "0x17000174")]
		public X509Certificate2Collection Certificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDE3F4", Offset = "0x1EDE3F4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00003F80 File Offset: 0x00002180
		[global::Cpp2ILInjected.Token(Token = "0x17000175")]
		private X509Stores Factory
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDE474", Offset = "0x1EDE474", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00003F83 File Offset: 0x00002183
		[global::Cpp2ILInjected.Token(Token = "0x17000176")]
		internal X509Store Store
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDE490", Offset = "0x1EDE490", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00003F86 File Offset: 0x00002186
		[global::Cpp2ILInjected.Token(Token = "0x60006BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE498", Offset = "0x1EDE498", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003F89 File Offset: 0x00002189
		[global::Cpp2ILInjected.Token(Token = "0x60006BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE4B4", Offset = "0x1EDE4B4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00003F8C File Offset: 0x0000218C
		[global::Cpp2ILInjected.Token(Token = "0x60006BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE4D0", Offset = "0x1EDE4D0", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(X509Store))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public void Open(OpenFlags flags)
		{
			throw null;
		}

		// Token: 0x040003CA RID: 970
		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _name;

		// Token: 0x040003CB RID: 971
		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private StoreLocation _location;

		// Token: 0x040003CC RID: 972
		[global::Cpp2ILInjected.Token(Token = "0x4000536")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Certificate2Collection list;

		// Token: 0x040003CD RID: 973
		[global::Cpp2ILInjected.Token(Token = "0x4000537")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private OpenFlags _flags;

		// Token: 0x040003CE RID: 974
		[global::Cpp2ILInjected.Token(Token = "0x4000538")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509Store store;
	}
}
