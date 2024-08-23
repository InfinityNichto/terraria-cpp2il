using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000556 RID: 1366
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallerCountAttribute : global::System.Attribute
	{
		// Token: 0x06002D5E RID: 11614 RVA: 0x0001C35E File Offset: 0x0001A55E
		public CallerCountAttribute()
		{
			throw null;
		}

		// Token: 0x040016CA RID: 5834
		public int Count;
	}
}
