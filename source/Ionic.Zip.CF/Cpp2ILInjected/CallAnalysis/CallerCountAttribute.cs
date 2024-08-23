using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000058 RID: 88
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x00005AA3 File Offset: 0x00003CA3
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040002D3 RID: 723
		public int Count;
	}
}
