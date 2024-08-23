using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000019 RID: 25
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002155 File Offset: 0x00000355
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400003A RID: 58
		public int Count;
	}
}
