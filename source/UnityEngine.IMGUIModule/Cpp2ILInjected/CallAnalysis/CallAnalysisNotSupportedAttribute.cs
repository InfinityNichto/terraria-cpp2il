using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002320 File Offset: 0x00000520
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
