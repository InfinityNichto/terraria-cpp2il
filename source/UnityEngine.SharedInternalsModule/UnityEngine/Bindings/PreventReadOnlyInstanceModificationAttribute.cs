using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	internal class PreventReadOnlyInstanceModificationAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4250", Offset = "0x1FA4250", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PreventReadOnlyInstanceModificationAttribute()
		{
			throw null;
		}
	}
}
