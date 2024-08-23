using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200007C RID: 124
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x000032C2 File Offset: 0x000014C2
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400023E RID: 574
		public int Count;
	}
}
