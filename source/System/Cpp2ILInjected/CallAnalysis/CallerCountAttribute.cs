using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000387 RID: 903
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06001CE4 RID: 7396 RVA: 0x00007FC4 File Offset: 0x000061C4
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000FCC RID: 4044
		public int Count;
	}
}
