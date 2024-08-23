using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001F RID: 31
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000044D2 File Offset: 0x000026D2
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000049 RID: 73
		public int Count;
	}
}
