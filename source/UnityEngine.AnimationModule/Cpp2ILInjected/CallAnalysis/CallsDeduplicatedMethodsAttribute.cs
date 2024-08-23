using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000027 RID: 39
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002116 File Offset: 0x00000316
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400005A RID: 90
		public int Count;
	}
}
