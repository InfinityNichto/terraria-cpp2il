using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000024 RID: 36
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002119 File Offset: 0x00000319
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400002B RID: 43
		public int Count;
	}
}
