using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000145 RID: 325
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000C35 RID: 3125 RVA: 0x0000520D File Offset: 0x0000340D
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040004F2 RID: 1266
		public int Count;
	}
}
