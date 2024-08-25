using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Collections.LowLevel.Unsafe
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x2000029")]
	public class WriteAccessRequiredAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A49C", Offset = "0x1F6A49C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public WriteAccessRequiredAttribute()
		{
			throw null;
		}
	}
}
