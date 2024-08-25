using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000106")]
	[global::System.Serializable]
	public class ThreadStaticAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B5CC", Offset = "0x1C4B5CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ThreadStaticAttribute()
		{
			throw null;
		}
	}
}
