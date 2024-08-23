using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000079 RID: 121
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x000032B9 File Offset: 0x000014B9
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
