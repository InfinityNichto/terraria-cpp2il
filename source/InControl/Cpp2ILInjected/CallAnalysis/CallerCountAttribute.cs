using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020001E7 RID: 487
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x00003914 File Offset: 0x00001B14
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040003C7 RID: 967
		public int Count;
	}
}
