using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000024")]
	public abstract class ValidatorAttribute : NaughtyAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB59C8", Offset = "0x1CB59C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected ValidatorAttribute()
		{
			throw null;
		}
	}
}
