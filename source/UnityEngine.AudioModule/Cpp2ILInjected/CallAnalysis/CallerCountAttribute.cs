using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002098 File Offset: 0x00000298
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000012 RID: 18
		public int Count;
	}
}
