using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000056 RID: 86
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00005A9D File Offset: 0x00003C9D
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040002D1 RID: 721
		public int Count;
	}
}
