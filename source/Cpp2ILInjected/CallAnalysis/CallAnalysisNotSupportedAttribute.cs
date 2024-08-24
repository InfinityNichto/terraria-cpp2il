using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000764 RID: 1892
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x060047FA RID: 18426 RVA: 0x0002ED87 File Offset: 0x0002CF87
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
