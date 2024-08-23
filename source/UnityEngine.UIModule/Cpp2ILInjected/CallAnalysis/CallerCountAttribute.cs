using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000012 RID: 18
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000020DA File Offset: 0x000002DA
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000013 RID: 19
		public int Count;
	}
}
