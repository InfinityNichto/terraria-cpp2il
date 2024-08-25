using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Struct)]
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	public sealed class NativeContainerAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A47C", Offset = "0x1F6A47C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeContainerAttribute()
		{
			throw null;
		}
	}
}
