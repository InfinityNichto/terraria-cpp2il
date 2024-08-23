using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000054 RID: 84
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00003693 File Offset: 0x00001893
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400028E RID: 654
		public int Count;
	}
}
