using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000214F File Offset: 0x0000034F
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000038 RID: 56
		public int Count;
	}
}
