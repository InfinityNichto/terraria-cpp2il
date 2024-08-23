using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000020D4 File Offset: 0x000002D4
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000011 RID: 17
		public int Count;
	}
}
