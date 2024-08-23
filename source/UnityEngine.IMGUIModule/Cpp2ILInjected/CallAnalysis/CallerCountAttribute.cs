using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000025 RID: 37
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00002329 File Offset: 0x00000529
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040000E1 RID: 225
		public int Count;
	}
}
