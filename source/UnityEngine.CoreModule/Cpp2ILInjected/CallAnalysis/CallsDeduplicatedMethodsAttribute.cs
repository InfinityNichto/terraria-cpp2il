using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015B RID: 347
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00002F71 File Offset: 0x00001171
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000623 RID: 1571
		public int Count;
	}
}
