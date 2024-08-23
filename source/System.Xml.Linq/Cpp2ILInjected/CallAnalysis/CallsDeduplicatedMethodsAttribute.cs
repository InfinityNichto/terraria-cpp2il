using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00002287 File Offset: 0x00000487
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400003E RID: 62
		public int Count;
	}
}
