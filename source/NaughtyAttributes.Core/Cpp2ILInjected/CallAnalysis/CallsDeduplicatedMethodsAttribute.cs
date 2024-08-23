using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002C RID: 44
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000021A6 File Offset: 0x000003A6
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000038 RID: 56
		public int Count;
	}
}
