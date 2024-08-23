using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000024 RID: 36
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0000228D File Offset: 0x0000048D
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000040 RID: 64
		public int Count;
	}
}
