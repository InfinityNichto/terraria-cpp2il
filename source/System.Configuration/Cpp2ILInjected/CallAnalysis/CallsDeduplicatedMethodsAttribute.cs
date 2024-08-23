using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000020C2 File Offset: 0x000002C2
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000F RID: 15
		public int Count;
	}
}
