using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal class WritableAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3990", Offset = "0x1FA3990", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public WritableAttribute()
		{
			throw null;
		}
	}
}
