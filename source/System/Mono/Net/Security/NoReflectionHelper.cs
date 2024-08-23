using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000023 RID: 35
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	internal static class NoReflectionHelper
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00003125 File Offset: 0x00001325
		[global::Cpp2ILInjected.Token(Token = "0x600018C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4EE74", Offset = "0x1D4EE74", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static object GetProvider()
		{
			throw null;
		}
	}
}
