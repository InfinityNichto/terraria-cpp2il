using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = true)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	internal sealed class ExtensionOfNativeClassAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600034C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DA34", Offset = "0x1F7DA34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ExtensionOfNativeClassAttribute()
		{
			throw null;
		}
	}
}
