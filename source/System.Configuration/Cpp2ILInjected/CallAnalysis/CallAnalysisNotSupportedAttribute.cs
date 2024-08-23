using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000020BF File Offset: 0x000002BF
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
