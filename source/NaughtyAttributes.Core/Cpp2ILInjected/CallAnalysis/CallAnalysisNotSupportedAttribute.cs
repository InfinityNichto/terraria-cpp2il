using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200002B RID: 43
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000021A3 File Offset: 0x000003A3
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
