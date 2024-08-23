using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x02000008 RID: 8
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	internal class UsedByNativeCodeAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3ACC", Offset = "0x1FA3ACC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public UsedByNativeCodeAttribute()
		{
			throw null;
		}
	}
}
