using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		public int Count;
	}
}
