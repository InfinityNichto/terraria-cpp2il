using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Versioning
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003C2")]
	internal sealed class NonVersionableAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5093C", Offset = "0x1B5093C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NonVersionableAttribute()
		{
			throw null;
		}
	}
}
