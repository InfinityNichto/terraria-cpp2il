using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000384 RID: 900
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06001CE1 RID: 7393 RVA: 0x00007FBB File Offset: 0x000061BB
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
