using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000026 RID: 38
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002113 File Offset: 0x00000313
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
