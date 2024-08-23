using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000144 RID: 324
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x0000520A File Offset: 0x0000340A
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
