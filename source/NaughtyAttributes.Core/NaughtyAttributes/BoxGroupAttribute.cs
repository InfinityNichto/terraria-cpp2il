using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	public class BoxGroupAttribute : GroupAttribute
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB57D4", Offset = "0x1CB57D4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BoxGroupAttribute(string name = "", int groupOrder = -1, string parentGroup = null, string subGroupCondition = null)
		{
			throw null;
		}
	}
}
