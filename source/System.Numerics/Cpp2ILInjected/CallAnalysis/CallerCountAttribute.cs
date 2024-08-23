using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002122 File Offset: 0x00000322
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000016 RID: 22
		public int Count;
	}
}
