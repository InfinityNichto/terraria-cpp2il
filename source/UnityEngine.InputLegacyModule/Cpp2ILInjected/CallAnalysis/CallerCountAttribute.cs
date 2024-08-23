using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000020BC File Offset: 0x000002BC
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000035 RID: 53
		public int Count;
	}
}
