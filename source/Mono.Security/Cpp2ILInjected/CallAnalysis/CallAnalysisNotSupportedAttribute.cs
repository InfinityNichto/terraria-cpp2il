using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000051 RID: 81
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000368A File Offset: 0x0000188A
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
