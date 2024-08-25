using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Assembly)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal class UnityEngineModuleAssembly : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3998", Offset = "0x1FA3998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEngineModuleAssembly()
		{
			throw null;
		}
	}
}
