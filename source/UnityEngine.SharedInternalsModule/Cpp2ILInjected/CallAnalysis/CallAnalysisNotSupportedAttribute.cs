using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002116 File Offset: 0x00000316
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
