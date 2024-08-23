using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security.Private
{
	// Token: 0x02000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	internal static class CallbackHelpers
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000312E File Offset: 0x0000132E
		[global::Cpp2ILInjected.Token(Token = "0x600018F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4EF10", Offset = "0x1D4EF10", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(SslStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "SetAndVerifyValidationCallback", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoRemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback)
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003131 File Offset: 0x00001331
		[global::Cpp2ILInjected.Token(Token = "0x6000190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49D98", Offset = "0x1D49D98", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings),
			typeof(bool),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalCertSelectionCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			throw null;
		}

		// Token: 0x020003AC RID: 940
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200006A")]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06001D17 RID: 7447 RVA: 0x00008039 File Offset: 0x00006239
			[global::Cpp2ILInjected.Token(Token = "0x6000191")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4EFBC", Offset = "0x1D4EFBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass0_0()
			{
				throw null;
			}

			// Token: 0x06001D18 RID: 7448 RVA: 0x0000803C File Offset: 0x0000623C
			[global::Cpp2ILInjected.Token(Token = "0x6000192")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4EFCC", Offset = "0x1D4EFCC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e)
			{
				throw null;
			}

			// Token: 0x04001073 RID: 4211
			[global::Cpp2ILInjected.Token(Token = "0x400012F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public RemoteCertificateValidationCallback callback;
		}

		// Token: 0x020003AD RID: 941
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200006B")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06001D19 RID: 7449 RVA: 0x0000803F File Offset: 0x0000623F
			[global::Cpp2ILInjected.Token(Token = "0x6000193")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4EFC4", Offset = "0x1D4EFC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass6_0()
			{
				throw null;
			}

			// Token: 0x06001D1A RID: 7450 RVA: 0x00008042 File Offset: 0x00006242
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4EFE0", Offset = "0x1D4EFE0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai)
			{
				throw null;
			}

			// Token: 0x04001074 RID: 4212
			[global::Cpp2ILInjected.Token(Token = "0x4000130")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MonoLocalCertificateSelectionCallback callback;
		}
	}
}
