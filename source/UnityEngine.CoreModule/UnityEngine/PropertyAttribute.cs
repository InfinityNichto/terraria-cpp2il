using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	public abstract class PropertyAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600027D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A10", Offset = "0x1F78A10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.HexadecimalAttribute", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected PropertyAttribute()
		{
			throw null;
		}
	}
}
