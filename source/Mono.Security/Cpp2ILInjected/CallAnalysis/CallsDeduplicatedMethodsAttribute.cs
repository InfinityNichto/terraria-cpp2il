using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000052 RID: 82
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000368D File Offset: 0x0000188D
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400028C RID: 652
		public int Count;
	}
}
