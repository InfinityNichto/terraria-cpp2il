using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015D RID: 349
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x00002F77 File Offset: 0x00001177
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000625 RID: 1573
		public int Count;
	}
}
