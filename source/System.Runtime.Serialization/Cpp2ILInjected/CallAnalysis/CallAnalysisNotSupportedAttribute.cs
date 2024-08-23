using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
