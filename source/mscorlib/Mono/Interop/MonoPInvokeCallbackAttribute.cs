using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Interop
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	internal sealed class MonoPInvokeCallbackAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADA00", Offset = "0x1AADA00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MonoPInvokeCallbackAttribute(global::System.Type t)
		{
			throw null;
		}
	}
}
