using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002065 File Offset: 0x00000265
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
