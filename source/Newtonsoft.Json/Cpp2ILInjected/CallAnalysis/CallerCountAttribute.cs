using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x020000EF RID: 239
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : Attribute
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x00003F05 File Offset: 0x00002105
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x04000359 RID: 857
		public int Count;
	}
}
