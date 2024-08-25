using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
	public sealed class DisallowMultipleComponent : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CC3C", Offset = "0x1F7CC3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DisallowMultipleComponent()
		{
			throw null;
		}
	}
}
