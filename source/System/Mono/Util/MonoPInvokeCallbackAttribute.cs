using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Util
{
	// Token: 0x02000008 RID: 8
	[Conditional("FULL_AOT_RUNTIME")]
	[Conditional("UNITY")]
	[AttributeUsage(AttributeTargets.Method)]
	[Conditional("MONOTOUCH")]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002E97 File Offset: 0x00001097
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D41620", Offset = "0x1D41620", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MonoPInvokeCallbackAttribute(Type t)
		{
			throw null;
		}
	}
}
