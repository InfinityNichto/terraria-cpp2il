using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001A RID: 26
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002107 File Offset: 0x00000307
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400003E RID: 62
		public int Count;
	}
}
