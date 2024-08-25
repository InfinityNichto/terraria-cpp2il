using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class)]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
	public class ExcludeFromObjectFactoryAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000348")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D92C", Offset = "0x1F7D92C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ExcludeFromObjectFactoryAttribute()
		{
			throw null;
		}
	}
}
