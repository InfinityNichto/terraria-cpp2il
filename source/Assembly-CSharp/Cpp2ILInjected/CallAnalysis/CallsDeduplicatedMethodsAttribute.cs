using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000765 RID: 1893
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x060047FB RID: 18427 RVA: 0x0002ED8A File Offset: 0x0002CF8A
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040077EA RID: 30698
		public int Count;
	}
}
