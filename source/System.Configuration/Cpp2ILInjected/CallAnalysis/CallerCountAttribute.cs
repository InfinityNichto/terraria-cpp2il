using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000020C8 File Offset: 0x000002C8
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000011 RID: 17
		public int Count;
	}
}
