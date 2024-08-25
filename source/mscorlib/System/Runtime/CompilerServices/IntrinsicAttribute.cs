using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000476")]
	internal sealed class IntrinsicAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600221C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B735A0", Offset = "0x1B735A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public IntrinsicAttribute()
		{
			throw null;
		}
	}
}
