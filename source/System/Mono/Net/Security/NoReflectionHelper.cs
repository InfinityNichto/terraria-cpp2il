using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	internal static class NoReflectionHelper
	{
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
