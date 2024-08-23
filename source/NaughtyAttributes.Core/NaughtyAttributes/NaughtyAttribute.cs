using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200001F RID: 31
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public class NaughtyAttribute : Attribute
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000215B File Offset: 0x0000035B
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB52CC", Offset = "0x1CB52CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NaughtyAttribute()
		{
			throw null;
		}
	}
}
