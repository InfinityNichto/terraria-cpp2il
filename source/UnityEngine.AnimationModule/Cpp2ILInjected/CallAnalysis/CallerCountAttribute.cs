using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000029 RID: 41
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0000211C File Offset: 0x0000031C
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400005C RID: 92
		public int Count;
	}
}
