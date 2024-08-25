using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	[AttributeUsage(AttributeTargets.Struct)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000025")]
	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A48C", Offset = "0x1F6A48C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute()
		{
			throw null;
		}
	}
}
