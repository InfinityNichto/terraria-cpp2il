using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x000044CF File Offset: 0x000026CF
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
