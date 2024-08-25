using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
	public class ExcludeFromPresetAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CCE0", Offset = "0x1F7CCE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ExcludeFromPresetAttribute()
		{
			throw null;
		}
	}
}
