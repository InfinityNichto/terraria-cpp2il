using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000767 RID: 1895
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x060047FD RID: 18429 RVA: 0x0002ED90 File Offset: 0x0002CF90
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040077EC RID: 30700
		public int Count;
	}
}
