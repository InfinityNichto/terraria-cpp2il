using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace Mono
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	internal class SystemDependencyProvider : ISystemDependencyProvider
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002E5B File Offset: 0x0000105B
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public static SystemDependencyProvider Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000021")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40C90", Offset = "0x1D40C90", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E5E File Offset: 0x0000105E
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40CEC", Offset = "0x1D40CEC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemDependencyProvider), Member = "get_Instance", ReturnType = typeof(SystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "InitializeInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemDependencyProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void Initialize()
		{
			throw null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002E61 File Offset: 0x00001061
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		private ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40ECC", Offset = "0x1D40ECC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002E64 File Offset: 0x00001064
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public SystemCertificateProvider CertificateProvider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000024")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40ED4", Offset = "0x1D40ED4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002E67 File Offset: 0x00001067
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public X509PalImpl X509Pal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40EDC", Offset = "0x1D40EDC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemCertificateProvider), Member = "get_X509Pal", ReturnType = typeof(X509PalImpl))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002E6A File Offset: 0x0000106A
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40E34", Offset = "0x1D40E34", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemDependencyProvider), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Mono.DependencyInjector", Member = "Register", MemberParameters = new object[] { "Mono.ISystemDependencyProvider" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private SystemDependencyProvider()
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002E6D File Offset: 0x0000106D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40EE0", Offset = "0x1D40EE0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SystemDependencyProvider()
		{
			throw null;
		}

		// Token: 0x04000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		private static SystemDependencyProvider instance;

		// Token: 0x04000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		private static object syncRoot;

		// Token: 0x04000006 RID: 6
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SystemCertificateProvider <CertificateProvider>k__BackingField;
	}
}
