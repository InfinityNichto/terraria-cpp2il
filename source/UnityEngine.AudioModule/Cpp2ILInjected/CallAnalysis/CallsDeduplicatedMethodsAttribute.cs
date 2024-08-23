using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000015 RID: 21
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002092 File Offset: 0x00000292
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000010 RID: 16
		public int Count;
	}
}
