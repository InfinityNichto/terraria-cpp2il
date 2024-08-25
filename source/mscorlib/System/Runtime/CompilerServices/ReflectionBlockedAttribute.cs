using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200048D")]
	internal class ReflectionBlockedAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002256")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B744E4", Offset = "0x1B744E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ReflectionBlockedAttribute()
		{
			throw null;
		}
	}
}
