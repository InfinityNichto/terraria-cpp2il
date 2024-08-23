using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000003 RID: 3
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	internal class SystemCertificateProvider : ISystemCertificateProvider
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002E3D File Offset: 0x0000103D
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40568", Offset = "0x1D40568", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImplMono), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static X509PalImpl GetX509Pal()
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002E40 File Offset: 0x00001040
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40610", Offset = "0x1D40610", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void EnsureInitialized()
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002E43 File Offset: 0x00001043
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public X509PalImpl X509Pal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40764", Offset = "0x1D40764", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new object[]
			{
				typeof(byte[]),
				"Mono.CertificateImportFlags"
			}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new object[]
			{
				typeof(byte[]),
				"Microsoft.Win32.SafeHandles.SafePasswordHandle",
				typeof(X509KeyStorageFlags),
				"Mono.CertificateImportFlags"
			}, ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "Import", MemberParameters = new object[]
			{
				typeof(X509Certificate),
				"Mono.CertificateImportFlags"
			}, ReturnType = typeof(X509Certificate2Impl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "EnsureInitialized", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002E46 File Offset: 0x00001046
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D407C0", Offset = "0x1D407C0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
		public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002E49 File Offset: 0x00001049
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40A18", Offset = "0x1D40A18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags)
		{
			throw null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002E4C File Offset: 0x0000104C
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40A1C", Offset = "0x1D40A1C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
		public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			throw null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002E4F File Offset: 0x0000104F
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40B14", Offset = "0x1D40B14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags)
		{
			throw null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002E52 File Offset: 0x00001052
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40B18", Offset = "0x1D40B18", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002E55 File Offset: 0x00001055
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40C18", Offset = "0x1D40C18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SystemCertificateProvider()
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002E58 File Offset: 0x00001058
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40C20", Offset = "0x1D40C20", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SystemCertificateProvider()
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		private static int initialized;

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		private static X509PalImpl x509pal;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		private static object syncRoot;
	}
}
