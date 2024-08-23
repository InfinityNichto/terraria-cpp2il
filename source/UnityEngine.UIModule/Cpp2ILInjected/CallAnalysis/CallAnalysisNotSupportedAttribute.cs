using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000020D1 File Offset: 0x000002D1
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
