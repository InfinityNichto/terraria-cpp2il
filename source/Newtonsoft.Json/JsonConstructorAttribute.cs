using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public sealed class JsonConstructorAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB6444", Offset = "0x1CB6444", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public JsonConstructorAttribute()
		{
			throw null;
		}
	}
}
