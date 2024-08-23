using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngineInternal
{
	// Token: 0x02000005 RID: 5
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69D50", Offset = "0x1F69D50", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TypeInferenceRuleAttribute(TypeInferenceRules rule)
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69DD4", Offset = "0x1F69DD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TypeInferenceRuleAttribute(string rule)
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69DFC", Offset = "0x1F69DFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _rule;
	}
}
