using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	internal class X509PalImplMono : X509PalImpl
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002E73 File Offset: 0x00001073
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40FA0", Offset = "0x1D40FA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509Certificate2Impl))]
		public override X509CertificateImpl Import(byte[] data)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002E76 File Offset: 0x00001076
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40FA4", Offset = "0x1D40FA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			"Microsoft.Win32.SafeHandles.SafePasswordHandle",
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(X509Certificate2Impl))]
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E79 File Offset: 0x00001079
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D40FA8", Offset = "0x1D40FA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override X509Certificate2Impl Import(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E7C File Offset: 0x0000107C
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D405B8", Offset = "0x1D405B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemCertificateProvider), Member = "GetX509Pal", ReturnType = typeof(X509PalImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509PalImplMono()
		{
			throw null;
		}
	}
}
