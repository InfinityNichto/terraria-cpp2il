using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400000F RID: 15
		public int Count;
	}
}
