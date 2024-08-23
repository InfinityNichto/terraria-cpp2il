using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
