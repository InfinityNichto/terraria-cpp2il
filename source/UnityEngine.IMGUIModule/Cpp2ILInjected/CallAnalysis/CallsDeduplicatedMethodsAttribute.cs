using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002323 File Offset: 0x00000523
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x040000DF RID: 223
		public int Count;
	}
}
