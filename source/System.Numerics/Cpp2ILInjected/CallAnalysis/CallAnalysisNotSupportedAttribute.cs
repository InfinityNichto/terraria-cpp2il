using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000E RID: 14
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002119 File Offset: 0x00000319
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
