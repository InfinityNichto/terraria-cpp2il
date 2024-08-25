using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
	public sealed class OnErrorAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D02FAC", Offset = "0x1D02FAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OnErrorAttribute()
		{
			throw null;
		}
	}
}
