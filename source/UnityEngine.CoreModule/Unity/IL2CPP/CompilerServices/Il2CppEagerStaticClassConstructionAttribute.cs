using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A000", Offset = "0x1F6A000", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public Il2CppEagerStaticClassConstructionAttribute()
		{
			throw null;
		}
	}
}
