using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000028 RID: 40
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00002119 File Offset: 0x00000319
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400005B RID: 91
		public int Count;
	}
}
