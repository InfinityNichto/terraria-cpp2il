using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x000044D8 File Offset: 0x000026D8
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400004B RID: 75
		public int Count;
	}
}
