using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000010 RID: 16
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000020B3 File Offset: 0x000002B3
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
