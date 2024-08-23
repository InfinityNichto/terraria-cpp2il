using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002E RID: 46
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000021AC File Offset: 0x000003AC
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400003A RID: 58
		public int Count;
	}
}
