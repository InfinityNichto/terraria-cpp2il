using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallsDeduplicatedMethodsAttribute : Attribute
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000233B File Offset: 0x0000053B
		public CallsDeduplicatedMethodsAttribute()
		{
			throw null;
		}

		// Token: 0x04000049 RID: 73
		public int Count;
	}
}
