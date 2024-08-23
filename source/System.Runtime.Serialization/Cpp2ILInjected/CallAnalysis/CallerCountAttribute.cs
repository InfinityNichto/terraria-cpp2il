using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		public int Count;
	}
}
