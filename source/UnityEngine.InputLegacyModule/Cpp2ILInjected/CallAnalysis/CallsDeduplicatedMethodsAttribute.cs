using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000020B6 File Offset: 0x000002B6
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000033 RID: 51
		public int Count;
	}
}
