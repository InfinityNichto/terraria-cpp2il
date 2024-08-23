using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Scripting
{
	// Token: 0x020000DF RID: 223
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000FF")]
	public class PreserveAttribute : Attribute
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00002B48 File Offset: 0x00000D48
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89EE8", Offset = "0x1F89EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeInitializeOnLoadMethodAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeInitializeOnLoadMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(RuntimeInitializeLoadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PreserveAttribute()
		{
			throw null;
		}
	}
}
