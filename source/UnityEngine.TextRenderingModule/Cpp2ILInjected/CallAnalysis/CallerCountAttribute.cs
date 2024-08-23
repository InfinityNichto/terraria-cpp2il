using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000020C5 File Offset: 0x000002C5
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000052 RID: 82
		public int Count;
	}
}
