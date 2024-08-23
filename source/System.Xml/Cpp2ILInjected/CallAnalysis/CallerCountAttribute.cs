using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000147 RID: 327
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x00005213 File Offset: 0x00003413
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040004F4 RID: 1268
		public int Count;
	}
}
