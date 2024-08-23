using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public sealed class X509StoreManager
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000032C1 File Offset: 0x000014C1
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A94ED8", Offset = "0x1A94ED8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private X509StoreManager()
		{
			throw null;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000032C4 File Offset: 0x000014C4
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		internal static string CurrentUserPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000166")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A94EE0", Offset = "0x1A94EE0", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000032C7 File Offset: 0x000014C7
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		internal static string LocalMachinePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000167")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A94FE0", Offset = "0x1A94FE0", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000032CA File Offset: 0x000014CA
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		internal static string NewCurrentUserPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000168")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A950C8", Offset = "0x1A950C8", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_NewCurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000032CD File Offset: 0x000014CD
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		internal static string NewLocalMachinePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000169")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A951B0", Offset = "0x1A951B0", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_NewLocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000032D0 File Offset: 0x000014D0
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		public static X509Stores CurrentUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95298", Offset = "0x1A95298", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_UntrustedCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUserPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000032D3 File Offset: 0x000014D3
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		public static X509Stores LocalMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95360", Offset = "0x1A95360", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "get_Factory", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new object[] { typeof(OpenFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_IntermediateCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCACrls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509StoreManager), Member = "get_UntrustedCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachinePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000032D6 File Offset: 0x000014D6
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public static X509Stores NewCurrentUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A953F8", Offset = "0x1A953F8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000032D9 File Offset: 0x000014D9
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public static X509Stores NewLocalMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95494", Offset = "0x1A95494", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000032DC File Offset: 0x000014DC
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public static X509CertificateCollection IntermediateCACertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95530", Offset = "0x1A95530", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "get_IntermediateCA", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000032DF File Offset: 0x000014DF
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public static ArrayList IntermediateCACrls
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A956B0", Offset = "0x1A956B0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "get_IntermediateCA", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000032E2 File Offset: 0x000014E2
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public static X509CertificateCollection TrustedRootCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000170")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A91224", Offset = "0x1A91224", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "get_TrustedRoot", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000032E5 File Offset: 0x000014E5
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public static ArrayList TrustedRootCACrls
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000171")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A95820", Offset = "0x1A95820", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "get_TrustedRoot", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "get_Crls", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000032E8 File Offset: 0x000014E8
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public static X509CertificateCollection UntrustedCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000172")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A958BC", Offset = "0x1A958BC", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Stores), Member = "get_Untrusted", ReturnType = typeof(X509Store))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Store), Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		private static string _userPath;

		// Token: 0x04000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		private static string _localMachinePath;

		// Token: 0x04000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		private static string _newUserPath;

		// Token: 0x04000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		private static string _newLocalMachinePath;

		// Token: 0x04000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		private static X509Stores _userStore;

		// Token: 0x04000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		private static X509Stores _machineStore;

		// Token: 0x04000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		private static X509Stores _newUserStore;

		// Token: 0x04000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		private static X509Stores _newMachineStore;
	}
}
