using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200015C RID: 348
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsUnknownMethodsAttribute : Attribute
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00002F74 File Offset: 0x00001174
		public CallsUnknownMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000624 RID: 1572
		public int Count;
	}
}
