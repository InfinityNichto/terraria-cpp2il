using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001C RID: 28
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000210D File Offset: 0x0000030D
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000040 RID: 64
		public int Count;
	}
}
