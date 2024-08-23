using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		public int Count;
	}
}
