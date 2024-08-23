using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000013 RID: 19
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000020BC File Offset: 0x000002BC
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
