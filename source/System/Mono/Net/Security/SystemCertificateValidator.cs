using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000024 RID: 36
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	internal static class SystemCertificateValidator
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00003128 File Offset: 0x00001328
		[global::Cpp2ILInjected.Token(Token = "0x600018D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4EEC0", Offset = "0x1D4EEC0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SystemCertificateValidator()
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000312B File Offset: 0x0000132B
		[global::Cpp2ILInjected.Token(Token = "0x600018E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A518", Offset = "0x1D4A518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool NeedsChain(MonoTlsSettings settings)
		{
			throw null;
		}

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		private static bool is_macosx;

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		private static X509KeyUsageFlags s_flags;
	}
}
