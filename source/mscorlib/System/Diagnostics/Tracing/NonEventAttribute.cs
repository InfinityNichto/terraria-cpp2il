using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x20005DD")]
	public sealed class NonEventAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06958", Offset = "0x1C06958", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NonEventAttribute()
		{
			throw null;
		}
	}
}
