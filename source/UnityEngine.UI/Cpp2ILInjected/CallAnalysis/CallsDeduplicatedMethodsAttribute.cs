using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200007A RID: 122
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x000032BC File Offset: 0x000014BC
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x0400023C RID: 572
		public int Count;
	}
}
