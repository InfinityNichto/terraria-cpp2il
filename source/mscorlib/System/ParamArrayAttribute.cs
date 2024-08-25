using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	public sealed class ParamArrayAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60008CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C442E8", Offset = "0x1C442E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ParamArrayAttribute()
		{
			throw null;
		}
	}
}
