using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal class ThreadAndSerializationSafeAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3988", Offset = "0x1FA3988", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ThreadAndSerializationSafeAttribute()
		{
			throw null;
		}
	}
}
