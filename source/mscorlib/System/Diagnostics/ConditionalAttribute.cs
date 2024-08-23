using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004D6 RID: 1238
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Method, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005C7")]
	[global::System.Serializable]
	public sealed class ConditionalAttribute : global::System.Attribute
	{
		// Token: 0x060029EB RID: 10731 RVA: 0x0001BA0A File Offset: 0x00019C0A
		[global::Cpp2ILInjected.Token(Token = "0x6002D4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C047E8", Offset = "0x1C047E8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ConditionalAttribute(string conditionString)
		{
			throw null;
		}

		// Token: 0x0400156B RID: 5483
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400194E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <ConditionString>k__BackingField;
	}
}
