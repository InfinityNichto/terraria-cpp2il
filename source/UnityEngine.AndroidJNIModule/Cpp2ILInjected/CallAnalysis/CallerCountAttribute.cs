using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001F RID: 31
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002341 File Offset: 0x00000541
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x0400004B RID: 75
		public int Count;
	}
}
