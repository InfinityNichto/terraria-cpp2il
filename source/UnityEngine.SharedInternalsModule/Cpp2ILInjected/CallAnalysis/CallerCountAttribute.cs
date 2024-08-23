using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000026 RID: 38
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000211F File Offset: 0x0000031F
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400002D RID: 45
		public int Count;
	}
}
