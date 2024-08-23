using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public class HideIfAttribute : ShowIfAttribute
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB52D4", Offset = "0x1CB52D4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShowIfAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public HideIfAttribute(string condition)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5388", Offset = "0x1CB5388", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public HideIfAttribute(ConditionOperator conditionOperator, params string[] conditions)
		{
			throw null;
		}
	}
}
