using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000206E File Offset: 0x0000026E
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000008 RID: 8
		public int Count;
	}
}
