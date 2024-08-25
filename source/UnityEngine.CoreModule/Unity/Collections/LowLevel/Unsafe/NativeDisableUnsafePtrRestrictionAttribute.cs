using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Field)]
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A4A4", Offset = "0x1F6A4A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeDisableUnsafePtrRestrictionAttribute()
		{
			throw null;
		}
	}
}
